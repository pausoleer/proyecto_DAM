using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkflowProject
{
    public partial class NuevaFase : Form
    {
        SessionManager sessionManager = SessionManager.GetInstance();
        private string idTarea;
        private Fases fasesForm;
        public NuevaFase(string idTarea, Fases fasesForm)
        {
            InitializeComponent();
            this.idTarea = idTarea;
            this.fasesForm = fasesForm;
            tbDescripcion.MaxLength = 60;
            tbDescripcion.Text = "Nombre de la fase...";
            tbDescripcion.ForeColor = Color.Gray;
        }
        private void NuevaFase_Load(object sender, EventArgs e)
        {
            Nuevas_Fases();
        }
        

        private void Nuevas_Fases()
        {
            SqlConnection conexion = sessionManager.GetConnection();

            string query = "SELECT * FROM Fase WHERE idTarea = @idTarea";
            string query2 = "SELECT * FROM Usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@idTarea", idTarea);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbAnterior.Items.Add(new { Descripcion = reader["descripcion"].ToString(), ID = reader["id"].ToString() });
                    }
                }
            }
            
            cbAnterior.DisplayMember = "descripcion";
            cbAnterior.ValueMember = "id";
            using (SqlCommand command = new SqlCommand(query2, conexion))
            {
                command.Parameters.AddWithValue("@idTarea", idTarea);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbUsuario.Items.Add(new { user_name = reader["user_name"].ToString(), ID = reader["id"].ToString() });

                    }
                }
            }
            cbUsuario.DisplayMember = "user_name";
            cbUsuario.ValueMember = "id";
        }
        private void btExe_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string nombre = Path.GetFileName(openFileDialog2.FileName);
            tbExe.Text = nombre;
        }
        private DateTime ObtenerFechaFaseAnterior(string idFaseAnterior)
        {
            DateTime fechaFaseAnterior = DateTime.MinValue;
            string query = "SELECT fecha_inicio FROM Fase WHERE id = @idFaseAnterior";
            using (SqlCommand command = new SqlCommand(query, sessionManager.GetConnection()))
            {
                command.Parameters.AddWithValue("@idFaseAnterior", idFaseAnterior);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fechaFaseAnterior = Convert.ToDateTime(reader["fecha_inicio"]);
                    }
                }
            }
            return fechaFaseAnterior;
        }

        private void btSafe_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fase anterior
            if (cbAnterior.SelectedItem != null)
            {
                string idFaseAnterior = ((dynamic)cbAnterior.SelectedItem).ID;
                DateTime fechaFaseAnterior = ObtenerFechaFaseAnterior(idFaseAnterior);

                // Si la fecha de inicio es anterior a la de la fase anterior, mostrar mensaje de error
                if (dtpInicio.Value <= fechaFaseAnterior)
                {
                    lErrorFecha.Text = "La fecha de inicio debe ser posterior a la de la fase anterior.";
                    lErrorFecha.Visible = true;
                    return; 
                }
            }
            // Verificar si ya existe una fase con el mismo nombre para la tarea actual
            string descripcionFase = tbDescripcion.Text.Trim();
            string queryVerificar = "SELECT COUNT(*) FROM Fase WHERE descripcion = @descripcion AND idTarea = @idTarea";
            using (SqlCommand commandVerificar = new SqlCommand(queryVerificar, sessionManager.GetConnection()))
            {
                commandVerificar.Parameters.AddWithValue("@descripcion", descripcionFase);
                commandVerificar.Parameters.AddWithValue("@idTarea", idTarea);
                int count = Convert.ToInt32(commandVerificar.ExecuteScalar());
                if (count > 0)
                {
                    lNombre.Text = "Ya existe una fase con ese nombre.";
                    lNombre.Visible = true;
                    return; 
                }
            }
            // Construir la consulta INSERT INTO
            string query = "INSERT INTO Fase (id, idTarea, idAnterior, ejecutable, descripcion, idUsuario, fecha_inicio, estados) VALUES (@id, @idTarea, @idAnterior, @ejecutable, @descripcion, @idUsuario, @fecha_inicio, @estados)";
            string newID = Guid.NewGuid().ToString();

            using (SqlCommand command = new SqlCommand(query, sessionManager.GetConnection()))
            {
                // Agregar parámetros con los valores de los TextBox
                command.Parameters.AddWithValue("@id", newID);
                command.Parameters.AddWithValue("@idTarea", idTarea);
                string idAnterior = null;
                if (cbAnterior.SelectedItem != null)
                {
                    idAnterior = ((dynamic)cbAnterior.SelectedItem).ID;
                    command.Parameters.AddWithValue("@idAnterior", idAnterior);
                }
                else
                {
                    command.Parameters.AddWithValue("@idAnterior", DBNull.Value);
                }

                command.Parameters.AddWithValue("@descripcion", tbDescripcion.Text);
                command.Parameters.AddWithValue("@ejecutable", tbExe.Text);
                command.Parameters.AddWithValue("@estados", "Pendiente");
                if (cbUsuario.SelectedItem != null)
                {
                    command.Parameters.AddWithValue("@idUsuario", ((dynamic)cbUsuario.SelectedItem).ID);
                }
                command.Parameters.AddWithValue("@fecha_inicio", dtpInicio.Value.ToString("dd/MM/yyyy"));

                // Ejecutar la consulta
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    
                    fasesForm.clbFases.Items.Clear();

                    // Si se seleccionó una fase anterior, actualiza las fases que tenían esa fase como anterior
                    if (idAnterior != null)
                    {
                        string updateQuery = "UPDATE Fase SET idAnterior = @newId WHERE idAnterior = @oldId AND idTarea = @idTarea AND id <> @newId";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, sessionManager.GetConnection()))
                        {
                            updateCommand.Parameters.AddWithValue("@newId", newID);
                            updateCommand.Parameters.AddWithValue("@oldId", idAnterior);
                            updateCommand.Parameters.AddWithValue("@idTarea", idTarea);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    fasesForm.DatosFase();
                    fasesForm.clbFases.Refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al crear la fase.");
                }
            }
            sessionManager.CloseConnection();
        }

        private void tsAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser posterior.");
                dtpInicio.Value = DateTime.Now;
            }
            
        }
        
       
        private void tbDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                tbDescripcion.Text = "Nombre de la fase...";
                tbDescripcion.ForeColor = Color.Gray;
            }
        }

        private void tbDescripcion_Enter(object sender, EventArgs e)
        {
            if (tbDescripcion.Text == "Nombre de la fase...")
            {
                tbDescripcion.Text = "";
                tbDescripcion.ForeColor = Color.Black;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
