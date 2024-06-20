using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WorkflowProject
{
    public partial class Login : Form
    {
        // Instancia del SessionManager para manejar la sesión del usuario
        private SessionManager sessionManager = SessionManager.GetInstance();
        public Login()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);

        }
        private void Login_Load(object sender, EventArgs e)
        {
            tbUser.Text = "Nombre de usuario";
            tbUser.ForeColor = Color.LightGray;
            tbPass.Text = "Contraseña";
            tbPass.ForeColor = Color.LightGray;
            lblErrorLogin.Visible = false;
        }
        // Verifica si la contraseña ingresada corresponde a un administrador
        private bool VerificarPasswordAdmin(string password)
        {
            bool accesoPermitido = false;

            // Obtiene una conexión a la base de datos
            SqlConnection conexion = sessionManager.GetConnection();
            // Consulta SQL para verificar la contraseña del administrador
            string consulta = "SELECT COUNT(*) FROM Usuarios WHERE id = '0000' AND pass = @password";
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@password", password);
                // Asegúrate de que la conexión esté abierta. SessionManager.GetConnection() debería manejar esto, pero es una buena práctica verificarlo.
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                // Ejecuta la consulta y verifica el resultado
                int resultado = (int)comando.ExecuteScalar();
                if (resultado > 0)
                {
                    accesoPermitido = true;
                }
            }

            return accesoPermitido;
        }
        // Manejador del evento Click del botón de inicio de sesión
        private void btEnter_Click(object sender, EventArgs e)
        {
            // Obtiene la conexión a la base de datos.
            SqlConnection conexion = sessionManager.GetConnection();
            // Consulta SQL para verificar el usuario y contraseña
            string consulta = "SELECT * FROM Usuarios WHERE user_name='" + tbUser.Text + "' AND pass='" + tbPass.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                // Obtiene el idEquipo del usuario y lo almacena en SessionManager
                string idEquipo = dr["idEquipo"].ToString();
                dr.Close();
                sessionManager.IdEquipoUsuario = idEquipo;
                // Verifica si el usuario es administrador
                sessionManager.IsAdmin = VerificarPasswordAdmin(tbPass.Text);
                TareasForm tareasForm = new TareasForm();

                tareasForm.Show();

            }
            else
            {
                lblErrorLogin.Text = "Nombre de usuario o contraseña incorrectos!";
                lblErrorLogin.Visible = true;
            }

            sessionManager.CloseConnection();
        }

        // Permite iniciar sesión presionando Enter en lugar de hacer clic en el botón
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEnter.PerformClick();
            }
        }
        // Eventos para manejar el texto de placeholder de los campos de usuario y contraseña
        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Nombre de usuario";
                tbUser.ForeColor = Color.LightGray;
            }
        }
        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Text = "Contraseña";
                tbPass.ForeColor = Color.LightGray;
            }
        }
        // Limpia el texto de placeholder cuando el campo recibe el foco
        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Nombre de usuario")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.Black;
            }
            lblErrorLogin.Visible = false;
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "Contraseña")
            {
                tbPass.Text = "";
                tbPass.ForeColor = Color.Black;
            }
            lblErrorLogin.Visible = false;
        }
    }
}
