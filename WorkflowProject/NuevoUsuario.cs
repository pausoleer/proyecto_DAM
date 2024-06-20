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
    public partial class NuevoUsuario : Form
    {
        private SessionManager sessionManager = SessionManager.GetInstance();
        public NuevoUsuario()
        {
            InitializeComponent();
            tbName.Text = "Nombre de usuario...";
            tbName.ForeColor = Color.Gray;

            tbNewUser.Text = "Correo electrónico...";
            tbNewUser.ForeColor = Color.Gray;

            tbNewPass.Text = "Contraseña...";
            tbNewPass.ForeColor = Color.Gray;
        }
        // Carga los equipos disponibles al cargar el formulario
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // carga datos en la tabla 'workflow_databaseDataSet1.Equipo' 
            this.equipoTableAdapter.Fill(this.workflow_databaseDataSet1.Equipo);

        }
        // Maneja el evento click del botón Crear
        private void btCreate_Click(object sender, EventArgs e)
        {
            // Valida el nombre de usuario para que no contenga caracteres especiales
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9_]");
            if (regex.IsMatch(tbName.Text))
            {
                lblErrorNombre.Text = "Nombre de usuario no puede contener caracteres especiales.";
                lblErrorNombre.Visible = true;
                return;
            }
            // Valida la contraseña para que cumpla con los requisitos especificados
            regex = new System.Text.RegularExpressions.Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{6,}$");
            if (!regex.IsMatch(tbNewPass.Text))
            {
                lblErrorPass.Text = ("La contraseña debe tener al menos 6 caracteres.n\nLa contraseña debe contener mayúsculas y minúsculas.n\nLa contraseña debe contener al menos un carácter especial.\n");
                lblErrorPass.Visible = true;
                return;
            }
            // Valida el correo electrónico para que tenga un formato adecuado
            regex = new System.Text.RegularExpressions.Regex("^[^@]+@[^@]+\\.[^@]+$");
            if (!regex.IsMatch(tbNewUser.Text))
            {
                lCorreo.Text = "Correo electrónico inválido.";
                lCorreo.Visible = true;
                return;
            }
            // Verifica si ya existe un usuario con el mismo nombre
            string consultaNombre = "SELECT COUNT(*) FROM Usuarios WHERE user_name = @user_name";
            using (SqlCommand commandExistencia = new SqlCommand(consultaNombre, sessionManager.GetConnection()))
            {
                commandExistencia.Parameters.AddWithValue("@user_name", tbName.Text);
                int usuarioexiste = (int)commandExistencia.ExecuteScalar();
                if (usuarioexiste > 0)
                {
                    lUsuario.Text = "El nombre de usuario ya existe.";
                    lUsuario.Visible = true;
                    return;
                }
            }
            // Consulta SQL para insertar un nuevo usuario
            string consulta = "INSERT INTO Usuarios (id, user_name, email, pass, idEquipo) VALUES (@id, @user_name, @email, @pass, @idEquipo)";
            string newID = Guid.NewGuid().ToString();
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                // Agrega los parámetros con los valores de los campos de texto
                command.Parameters.AddWithValue("@id", newID);
                command.Parameters.AddWithValue("@user_name", tbName.Text);
                command.Parameters.AddWithValue("@email", tbNewUser.Text);
                command.Parameters.AddWithValue("@pass", tbNewPass.Text);

                // Obtiene el equipo seleccionado y lo asigna al nuevo usuario
                DataRowView selectedRow = cbEquipos.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    String idEquipo = (String)selectedRow["idEquipo"];
                    command.Parameters.AddWithValue("@idEquipo", idEquipo);
                    MessageBox.Show("Usuario creado!.");
                    //TareasForm tareasForm = new TareasForm();
                    //tareasForm.ShowDialog();
                    this.Close();
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



        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Limpia el texto de placeholder al entrar en el campo Nombre de usuario
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Nombre de usuario...")
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }
        // Restablece el texto de placeholder al salir del campo Nombre de usuario
        private void tbName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.Text = "Nombre de usuario...";
                tbName.ForeColor = Color.Gray;
            }
        }

        private void tbNewUser_Enter(object sender, EventArgs e)
        {
            if (tbNewUser.Text == "Correo electrónico...")
            {
                tbNewUser.Text = "";
                tbNewUser.ForeColor = Color.Black;
            }
        }
        private void tbNewUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewUser.Text))
            {
                tbNewUser.Text = "Correo electrónico...";
                tbNewUser.ForeColor = Color.Gray;
            }
        }

        private void tbNewPass_Enter(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "Contraseña...")
            {
                tbNewPass.Text = "";
                tbNewPass.ForeColor = Color.Black;
            }
        }
        private void tbNewPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewPass.Text))
            {
                tbNewPass.Text = "Contraseña...";
                tbNewPass.ForeColor = Color.Gray;
            }
        }
    }
}
