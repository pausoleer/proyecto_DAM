using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace WorkflowProject
{
    public partial class TareasForm : Form
    {
        private SessionManager sessionManager = SessionManager.GetInstance();
        public TareasForm()
        {
            InitializeComponent();
            // Ajusta todos los controles para que llenen el formulario
            foreach (Control control in this.Controls)
            {
                control.Dock = DockStyle.Fill;
            }
            // Maximiza la ventana cuando se muestra el formulario
            this.Shown += (sender, e) =>
            {
                this.WindowState = FormWindowState.Maximized;
                dgTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                

            };

        }
        // Carga los datos en el formulario
        private void TareasForm_Load(object sender, EventArgs e)
        {

            loadData();
            var height = dgTareas.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgTareas.Rows)
            {
                height += row.Height;
            }
            dgTareas.ColumnHeadersHeight = 55;
        }

        public void loadData()
        {
            // Obtiene la conexión a la base de datos
            SqlConnection conexion = sessionManager.GetConnection();
            string idEquipo = sessionManager.IdEquipoUsuario;

            if (string.IsNullOrEmpty(idEquipo))
            {
                return;
            }
            // Consulta SQL para obtener las tareas del equipo
            string query = "SELECT * FROM Tarea WHERE idEquipo = @idEquipo";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@idEquipo", idEquipo);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Tarea");
            // Establece el DataSource del DataGridView
            dgTareas.DataSource = dataSet.Tables["Tarea"];
            foreach (DataGridViewRow row in dgTareas.Rows)
            {
                row.Height = 50;
                

            }
            dgTareas.RowTemplate.Height = 50;
            // Muestra u oculta los botones según si el usuario es administrador
            tsUsuario.Visible = sessionManager.IsAdmin;
            tsModificar.Visible = sessionManager.IsAdmin;
        }
        // Manejador del evento click para el botón de eliminar tarea
        private void tsDelete_Click(object sender, EventArgs e)
        {

            if (dgTareas.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Seguro que quieres eliminar la tarea?", " Si eliminas perderás todos los datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgTareas.SelectedRows[0];

                    string id = selectedRow.Cells["id"].Value.ToString();
                    // Consulta SQL para eliminar las fases asociadas a la tarea
                    string consultaEliminarFases = "DELETE FROM Fase WHERE idTarea = @idTarea";

                    using (SqlCommand commandEliminarFases = new SqlCommand(consultaEliminarFases, sessionManager.GetConnection()))
                    {
                        commandEliminarFases.Parameters.AddWithValue("@idTarea", id);
                        commandEliminarFases.ExecuteNonQuery();
                    }
                    // Consulta SQL para eliminar la tarea
                    string consulta = "DELETE FROM Tarea WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        // Actualiza el DataGridView
                        if (rowsAffected > 0)
                        {
                            DataTable tabla = (DataTable)dgTareas.DataSource;
                            DataRow[] rows = tabla.Select("id = '" + id + "'");
                            if (rows.Length > 0)
                                rows[0].Delete();

                            tabla.AcceptChanges();
                            dgTareas.Refresh();

                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la tarea.");
                        }

                    }
                    sessionManager.CloseConnection();
                }

            }
        }
        // Manejador del evento click para el botón de agregar tarea
        private void tsAgregar_Click(object sender, EventArgs e)
        {
            NuevaTarea nuevaTarea = new NuevaTarea(this);
            nuevaTarea.Show();

        }
        // Manejador del evento doble click en una celda del DataGridView
        private void dgTareas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgTareas.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                Fases fasesForm = new Fases(id);
                fasesForm.Show();
                this.Close();
            }
        }
        // Manejador del evento click para el botón de agregar usuario
        private void tsUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();
        }
        // Manejador del evento click para el botón de modificar tarea
        private void tsModificar_Click(object sender, EventArgs e)
        {
            ModificarTareas modificarTareas = new ModificarTareas();
            modificarTareas.TareasModificada += ModificarTareas_TareaModificada;
            modificarTareas.Show();
        }
        private void ModificarTareas_TareaModificada(object sender, EventArgs e)
        {
            loadData(); // Recargar los datos de la tabla
        }
        // Exportar contenido
        private void tsExportar_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView dgTareas tiene filas de datos
            if (dgTareas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear y configurar SaveFileDialog para seleccionar dónde guardar el archivo CSV
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            guardarArchivo.FileName = "ExportacionTareas.csv";


            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear un StreamWriter para escribir en el archivo seleccionado
                    using (StreamWriter writer = new StreamWriter(new FileStream(guardarArchivo.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        // Escribir la cabecera
                        IEnumerable<string> columnNames = dgTareas.Columns.Cast<DataGridViewColumn>().Select(column => "\"" + column.HeaderText + "\"");
                        writer.WriteLine(string.Join(",", columnNames));

                        // Escribir las filas de datos
                        foreach (DataGridViewRow row in dgTareas.Rows)
                        {
                            if (!row.IsNewRow) 
                            {
                                IEnumerable<string> fields = row.Cells.Cast<DataGridViewCell>().Select(cell => "\"" + (cell.Value?.ToString().Replace("\"", "\"\"") ?? "") + "\"");
                                writer.WriteLine(string.Join(",", fields));
                            }
                        }
                    }

                    MessageBox.Show("Los datos se han exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }

}