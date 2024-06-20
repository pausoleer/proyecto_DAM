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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkflowProject
{
    public partial class NuevaTarea : Form
    {
        // Referencia al formulario de tareas para actualizar la lista de tareas
        TareasForm fgrid;

        public NuevaTarea(TareasForm fg)
        {
            InitializeComponent();
            this.fgrid = fg;
            tbNameTask.MaxLength = 36;
            tbDescripcion.MaxLength = 60;
            tbDescripcion.Text = "Descripción de la tarea...";
            tbDescripcion.ForeColor = Color.Gray;
            tbNameTask.Text = "Nombre de la tarea...";
            tbNameTask.ForeColor = Color.Gray;

        }

        // Verifica que la fecha límite sea posterior a la fecha actual
        private void dtpFechaLimite_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaLimite.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser posterior..");
                dtpFechaLimite.Value = DateTime.Now;
            }
        }
        // Maneja el evento click del botón Guardar
        private void btSafe_Click(object sender, EventArgs e)
        {
            SessionManager sessionManager = SessionManager.GetInstance();

            // Construye la consulta SQL para insertar una nueva tarea
            string query = "INSERT INTO Tarea (id, nombre, descripcion, estado, idEquipo, fecha_limite) VALUES (@id, @nombre, @descripcion, 'Pendiente', @idEquipo, @fecha_limite)";
            // Genera un nuevo ID para la tarea
            string newID = Guid.NewGuid().ToString();
            string idEquipo = sessionManager.IdEquipoUsuario;

            using (SqlCommand command = new SqlCommand(query, sessionManager.GetConnection()))
            {
                // Agregar parámetros con los valores de los TextBox
                command.Parameters.AddWithValue("@id", newID);
                command.Parameters.AddWithValue("@nombre", tbNameTask.Text);
                command.Parameters.AddWithValue("@descripcion", tbDescripcion.Text);
                command.Parameters.AddWithValue("@fecha_limite", dtpFechaLimite.Value);
                command.Parameters.AddWithValue("@idEquipo", idEquipo);

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Accede al origen de datos (DataTable) directamente y agrega la nueva tarea
                    DataTable new_data = (DataTable)fgrid.dgTareas.DataSource;
                    DataRow newRow = new_data.NewRow();
                    newRow["id"] = newID;
                    newRow["nombre"] = tbNameTask.Text;
                    newRow["descripcion"] = tbDescripcion.Text;
                    newRow["estado"] = "Pendiente";
                    newRow["idEquipo"] = idEquipo;
                    newRow["fecha_limite"] = dtpFechaLimite.Value;
                    new_data.Rows.Add(newRow);
                    // Actualiza el DataGridView en el formulario de tareas
                    fgrid.dgTareas.Refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la tarea.");
                }
            }
        }
        // Limpia el texto de placeholder al entrar en el campo Nombre de la tarea
        private void tbNameTask_Enter(object sender, EventArgs e)
        {
            if (tbNameTask.Text == "Nombre de la tarea...")
            {
                tbNameTask.Text = "";
                tbNameTask.ForeColor = Color.Black;
            }
        }
        // Restablece el texto de placeholder al salir del campo Nombre de la tarea
        private void tbNameTask_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNameTask.Text))
            {
                tbNameTask.Text = "Nombre de la tarea...";
                tbNameTask.ForeColor = Color.Gray;
            }
        }

        private void tbDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                tbDescripcion.Text = "Descripción de la tarea...";
                tbDescripcion.ForeColor = Color.Gray;
            }
        }

        private void tbDescripcion_Enter(object sender, EventArgs e)
        {
            if (tbDescripcion.Text == "Descripción de la tarea...")
            {
                tbDescripcion.Text = "";
                tbDescripcion.ForeColor = Color.Black;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}