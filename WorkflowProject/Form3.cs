using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace WorkflowProject
{
    public partial class Form3 : Form
    {
        private SessionManager sessionManager = SessionManager.GetInstance();
        public Form3()
        {
            InitializeComponent();
            //btTarea.Text = 

        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();

        }
        private void loadData ()
        {
            SqlConnection conexion = sessionManager.GetConnection();
            string idEquipo = sessionManager.IdEquipoUsuario;



            string query = "SELECT * FROM Tarea WHERE idEquipo = @idEquipo"; // añadir filtro where idequipo == sessionManager.idequipousuario que ha hecho login 
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@idEquipo", idEquipo);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Tarea");
            dgTareas.DataSource = dataSet.Tables["Tarea"];
            // borrar columna estado y añadir otra con:
            // dgTareas.Columns.Add.....
            // la columna que hay que pasar al add tendrá como contenido la imagen de una bola verde o roja según estado dependiendo de un switch sobre el
            //campo estado de la tabla tarea. La información está dentro de dataset.
            //DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
           // imgCol.Name = "EstadoImagen";
           // imgCol.HeaderText = "Estado";



        }
        private void tsDelete_Click(object sender, EventArgs e)
        {

            if (dgTareas.SelectedRows.Count > 0)
            {
                //SessionManager sessionManager = SessionManager.GetInstance();

                // Obtener la fila seleccionada en el DataGridView
                DataGridViewRow selectedRow = dgTareas.SelectedRows[0];
                
                // Obtener el valor del campo 'id' de la fila seleccionada
                string id = selectedRow.Cells["id"].Value.ToString();

                
                string consulta = "DELETE FROM Tarea WHERE id = @id";
                using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
                {
                    // Agregar parámetros con el valor del 'id'
                    command.Parameters.AddWithValue("@id", id);

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        // Eliminar la fila del DataTable enlazado al DataGridView
                        DataTable tabla = (DataTable)dgTareas.DataSource;
                        DataRow[] rows = tabla.Select("id = '" + id + "'");
                        if (rows.Length > 0)
                            rows[0].Delete();

                        // Notificar al DataGridView que se han realizado cambios
                        tabla.AcceptChanges();
                        dgTareas.Refresh();

                        MessageBox.Show("Tarea eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la tarea.");
                    }
                }

                // Cerrar la conexión
                sessionManager.CloseConnection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

            

        
        private void tsAgregar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();

        }
        


    }

}
