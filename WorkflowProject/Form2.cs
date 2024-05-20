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
    public partial class Form2 : Form
    {
        private SessionManager sessionManager = SessionManager.GetInstance();
        public Form2()
        {
            InitializeComponent();
        }
        // gráficamente añadir combobox o lo que encuentre para elegir el equipo. viene de la tabla equipos
        private void btCreate_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
            

            string consulta = "INSERT INTO Usuarios (id, user_name, email, pass, idEquipo) VALUES (@id, @user_name, @email, @pass, @idEquipo)";
            string newID = Guid.NewGuid().ToString();
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                // Agregar parámetros con los valores de los TextBox
                command.Parameters.AddWithValue("@id", newID);
                command.Parameters.AddWithValue("@user_name", tbName.Text);
                command.Parameters.AddWithValue("@email", tbNewUser.Text);
                command.Parameters.AddWithValue("@pass", tbNewPass.Text);
                

                DataRowView selectedRow = cbEquipos.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    String idEquipo = (String)selectedRow["idEquipo"];
                    command.Parameters.AddWithValue("@idEquipo", idEquipo);
                    MessageBox.Show("Usuario creado!.");
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un equipo válido.");
                    return;
                }


                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                
            }


            // Cerrar la conexión
            sessionManager.CloseConnection();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'workflow_databaseDataSet1.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.workflow_databaseDataSet1.Equipo);

        }
     
    }
}
