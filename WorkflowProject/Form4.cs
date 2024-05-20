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

namespace WorkflowProject
{
    public partial class Form4 : Form
    {
        Form3 fgrid;
        
        public Form4(Form3 fg)
        {
            InitializeComponent();
            this.fgrid = fg;
            
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            SessionManager sessionManager = SessionManager.GetInstance();
            
            // Construir la consulta INSERT INTO
            string query = "INSERT INTO Tarea (id, nombre, descripcion, estado, idEquipo) VALUES (@id, @nombre, @descripcion, 'pendiente', @idEquipo)";
            string newID = Guid.NewGuid().ToString();
            string idEquipo = sessionManager.IdEquipoUsuario;

            using (SqlCommand command = new SqlCommand(query, sessionManager.GetConnection()))
            {
                // Agregar parámetros con los valores de los TextBox
                command.Parameters.AddWithValue("@id", newID);
                command.Parameters.AddWithValue("@nombre", tbNameTask.Text);
                command.Parameters.AddWithValue("@descripcion", tbDescripcion.Text);
                command.Parameters.AddWithValue("@idEquipo", idEquipo);
                // command.Parameters.AddWithValue("@estado", tbEstado.Text);


                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    
                    // Acceder al origen de datos (DataTable) directamente
                    DataTable new_data = (DataTable)fgrid.dgTareas.DataSource;
                    // Agregar una nueva fila al DataTable
                    DataRow newRow = new_data.NewRow();
                    newRow["descripcion"] = tbDescripcion.Text;
                    newRow["estado"] = "pendiente";
                    newRow["idEquipo"] = idEquipo;
                    //newRow["id"] = newID;
                    new_data.Rows.Add(newRow);
                    
                    // Notificar al DataGridView que se han realizado cambios
                    fgrid.dgTareas.Refresh();
                    MessageBox.Show("Tarea agregada correctamente.");

                }
                else
                {
                    MessageBox.Show("No se pudo agregar la tarea.");
                }
            }
            

            // Cerrar la conexión
            sessionManager.CloseConnection();
        }


    }
}
