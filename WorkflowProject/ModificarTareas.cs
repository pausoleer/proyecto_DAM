using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WorkflowProject
{
    public partial class ModificarTareas : Form
    {
        SessionManager sessionManager = SessionManager.GetInstance();
        // Delegado y evento para notificar cuando una tarea ha sido modificada
        public delegate void TareaModificadaEventHandler();
        public event TareaModificadaEventHandler TareaModificada;
        public event EventHandler TareasModificada;
        public ModificarTareas()
        {
            InitializeComponent();
            tbNombre.MaxLength = 36;
            ttbDescripcion.MaxLength = 60;
            // Lista para almacenar los estados de las tareas
            var estados = new List<KeyValuePair<string, string>>();
            estados.Add(new KeyValuePair<string, string>("Pendiente", "Pendiente"));
            estados.Add(new KeyValuePair<string, string>("Completada", "Completada"));

            // Configura el ComboBox de estados con los valores de la lista
            cbEstado.DataSource = estados;
            cbEstado.DisplayMember = "Value";
            cbEstado.ValueMember = "Key";
        }
        // Carga las tareas existentes 
        public void ModificarTareas_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }
        // Consulta y carga las tareas desde la base de datos en el ComboBox
        public void CargarTareas()
        {
            string query = "SELECT id, nombre FROM Tarea";
            DataTable tareas = new DataTable();

            using (SqlCommand comando = new SqlCommand(query, sessionManager.GetConnection()))
            {

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tareas);

            }
            // Configura el ComboBox de tareas con los valores obtenidos
            cbTarea.DataSource = tareas;
            cbTarea.DisplayMember = "nombre";
            cbTarea.ValueMember = "id";
        }
        
        // Maneja el evento click del botón Guardar
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (cbTarea.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una tarea.");
                return;
            }

            // Consulta SQL para actualizar la tarea seleccionada
            string query = "UPDATE Tarea SET nombre = @nombre, descripcion = @descripcion, estado = @estado, fecha_limite = @fecha_limite WHERE id = @id";

            using (SqlCommand command = new SqlCommand(query, sessionManager.GetConnection()))
            {
                // Abre la conexión si no está abierta
                if (sessionManager.GetConnection().State != ConnectionState.Open)
                {
                    sessionManager.GetConnection().Open();
                }

                // Agregar parámetros con los valores de los controles
                command.Parameters.AddWithValue("@nombre", tbNombre.Text);
                command.Parameters.AddWithValue("@descripcion", ttbDescripcion.Text);
                command.Parameters.AddWithValue("@estado", cbEstado.SelectedValue);
                command.Parameters.AddWithValue("@fecha_limite", dtpFecha.Value);
                command.Parameters.AddWithValue("@id", cbTarea.SelectedValue);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    TareasModificada?.Invoke(this, EventArgs.Empty);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al modificar la tarea.");
                }
            }

            // Cerrar la conexión
            sessionManager.CloseConnection();

        }
        
        // Verifica que la fecha seleccionada no sea anterior a la fecha actual
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecha.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser posterior..");
                dtpFecha.Value = DateTime.Now;
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.Text = "Nombre de la Tarea...";
                tbNombre.ForeColor = Color.Gray;
            }
        }

        private void tbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text == "Nombre de la Tarea...")
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = Color.Black;
            }
        }

        private void ttbDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ttbDescripcion.Text))
            {
                ttbDescripcion.Text = "Descripción de la Tarea...";
                ttbDescripcion.ForeColor = Color.Gray;
            }
        }

        private void ttbDescripcion_Enter(object sender, EventArgs e)
        {
            if (ttbDescripcion.Text == "Descripción de la Tarea...")
            {
                ttbDescripcion.Text = "";
                ttbDescripcion.ForeColor = Color.Black;
            }
        }

        private void tsVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
