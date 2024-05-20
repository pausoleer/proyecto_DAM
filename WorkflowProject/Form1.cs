using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WorkflowProject
{
    public partial class Form1 : Form
    {
        private SessionManager sessionManager = SessionManager.GetInstance();
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection conexion = new SqlConnection("server=(localdb)\\Local;database=Workflow_database; integrated security=true");

        private void btNuevoUsuario_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = sessionManager.GetConnection();

            string consulta = "SELECT * FROM Usuarios WHERE user_name='" + tbUser.Text + "' AND pass='" + tbPass.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                string idEquipo = dr["idEquipo"].ToString();
                dr.Close();
                sessionManager.IdEquipoUsuario = idEquipo;
                Form3 form3 = new Form3();
                form3.ShowDialog();
                // sessionmanager.idequipousuario
                // dentro del singletn sessionManager guardar una public string idequipousuario que sea accesible durante toda la actividad de la app.
            }
            else
            {
                MessageBox.Show("Incorrecto!");
            }

            sessionManager.CloseConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
