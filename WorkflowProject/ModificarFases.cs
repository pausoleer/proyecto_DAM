using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkflowProject
{
    public partial class ModificarFases : Form
    {
        // Instancia del gestor de sesión para acceder a la conexión de base de datos y otros datos de sesión.
        SessionManager sessionManager = SessionManager.GetInstance();
        // Delegado y evento para notificar cuando una fase ha sido modificada.
        public delegate void FaseModificadaEventHandler();
        public event FaseModificadaEventHandler FaseModificada;
        private string _id;
        public ModificarFases(string id)
        {
            InitializeComponent();
            var estados = new List<KeyValuePair<string, string>>();
            estados.Add(new KeyValuePair<string, string>("Terminada", "Terminada"));
            estados.Add(new KeyValuePair<string, string>("Pendiente", "Pendiente"));
            cbEstados.DataSource = estados;
            cbEstados.DisplayMember = "Value";
            cbEstados.ValueMember = "Key";
            _id = id;
            
        }
        // Carga las fases asociadas a la tarea seleccionada desde la base de datos y las muestra en el combobox
        private void ModificarFases_Load(object sender, EventArgs e)
        {
            CargarFases();
        }
        private void CargarFases()
        {
            string query = "SELECT id, descripcion FROM Fase WHERE idTarea = @idTarea";
            DataTable fases = new DataTable();

            using (SqlCommand comando = new SqlCommand(query, sessionManager.GetConnection()))
            {
                comando.Parameters.AddWithValue("@idTarea", _id);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(fases);
            }

            cbFases.DataSource = fases;
            cbFases.DisplayMember = "descripcion";
            cbFases.ValueMember = "id";
        }
        // Método ejecutado al hacer clic en el botón Guardar, actualiza la fase seleccionada con los nuevos valores.
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (cbFases.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una tarea.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbEjecutable.Text))
            {
                MessageBox.Show("Por favor, seleccione un ejecutable.");
                return;
            }

            // Consulta SQL para actualizar la fase.
            string query = "UPDATE Fase SET descripcion = @descripcion, ejecutable = @ejecutable, estados = @estados, fecha_inicio = @fecha_inicio WHERE id = @id";

            using (SqlCommand command = new SqlCommand(query, sessionManager.GetConnection()))
            {
                // Abre la conexión si no está abierta
                if (sessionManager.GetConnection().State != ConnectionState.Open)
                {
                    sessionManager.GetConnection().Open();
                }

                // Agregar parámetros con los valores de los controles
                command.Parameters.AddWithValue("@descripcion", tbDescripcion.Text);
                command.Parameters.AddWithValue("@estados", cbEstados.SelectedValue);
                command.Parameters.AddWithValue("@ejecutable", tbEjecutable.Text);
                command.Parameters.AddWithValue("@fecha_inicio", dtpFecha.Value);
                command.Parameters.AddWithValue("@id", cbFases.SelectedValue);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    FaseModificada?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar la fase.");
                }
            }

            // Cerrar la conexión
            sessionManager.CloseConnection();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecha.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser posterior..");
                dtpFecha.Value = DateTime.Now;
            }
        }
        // Método ejecutado al hacer clic en el botón de agregar ejecutable, abre un diálogo para seleccionar un archivo
        private void btAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string nombre = Path.GetFileName(openFileDialog1.FileName);
            tbEjecutable.Text = nombre;
        }

        private void tbDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                tbDescripcion.Text = "Nombre de la Fase...";
                tbDescripcion.ForeColor = Color.Gray;
            }
        }

        private void tbDescripcion_Enter(object sender, EventArgs e)
        {
            if (tbDescripcion.Text == "Nombre de la Fase...")
            {
                tbDescripcion.Text = "";
                tbDescripcion.ForeColor = Color.Black;
            }
        }

        private void tsVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
