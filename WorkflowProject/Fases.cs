using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.MonthCalendar;
using PdfDocument = PdfSharp.Pdf.PdfDocument;

namespace WorkflowProject
{
    public partial class Fases : Form
    {
        private SessionManager sessionManager = SessionManager.GetInstance();
        private string _id;
        // Diccionario para almacenar las fases con su id y id anterior
        Dictionary<string, (string id, string idAnterior)> faseDict = new Dictionary<string, (string id, string idAnterior)>();
        public Fases(string id)
        {
            InitializeComponent();
            _id = id;
            gbInfoFase.Visible = false;
            // Ajustar los controles para que llenen el formulario
            foreach (Control control in this.Controls)
            {
                control.Dock = DockStyle.Fill;
            }
            this.Shown += (sender, e) =>
            {
                this.WindowState = FormWindowState.Maximized;
            };
        }
        private void Fases_Load(object sender, EventArgs e)
        {
            DatosFase();
        }
        // Cargar los datos de las fases desde la base de datos
        public void DatosFase()
        {
            faseDict.Clear();
            SqlConnection conexion = sessionManager.GetConnection();
            // Consulta SQL para obtener las fases asociadas a la tarea actual, ordenadas por su fase anterior
            string query = "SELECT * FROM Fase WHERE idTarea = @idTarea ORDER BY idAnterior";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@idTarea", _id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string descripcion = reader["descripcion"].ToString();
                        string id = reader["id"].ToString();
                        string idAnterior = reader.IsDBNull(reader.GetOrdinal("idAnterior")) ? null : reader["idAnterior"].ToString();

                        // Almacenar la información de la fase en el diccionario, usando la descripción como clave
                        faseDict[descripcion] = (id, idAnterior);
                    }
                }
            }

            clbFases.Items.Clear();

            // Añadir el primer elemento a la lista de fases
            var itemInicial = faseDict.FirstOrDefault(x => x.Value.idAnterior == null);
            if (!itemInicial.Equals(default(KeyValuePair<string, (string id, string idAnterior)>)))
            {
                clbFases.Items.Add(itemInicial.Key);
            }
            // Añadir elementos a la lista de fases siguiendo el orden establecido por idAnterior
            bool añadido;
            do
            {
                añadido = false;
                if (clbFases.Items.Count > 0) // Asegurarse de que hay elementos en clbFases.Items
                {
                    foreach (var item in faseDict)
                    {
                        if (clbFases.Items.Contains(item.Key)) continue;
                        var ultimoIdAñadido = faseDict[clbFases.Items[clbFases.Items.Count - 1].ToString()].id;
                        if (item.Value.idAnterior == ultimoIdAñadido)
                        {
                            clbFases.Items.Add(item.Key);
                            añadido = true;
                            break;
                        }
                    }
                }
            } while (añadido);

            tbCambiar.Visible = sessionManager.IsAdmin;
        }
        // Obtiene la ruta completa del script de PowerShell basado en una ruta relativa
        private string GetScriptPath(string fileName)
        {
            //string scriptFileName = fileName;
            //string relativePath = Path.Combine(@".\archivos", scriptFileName);
            //string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));
            //return fullPath;

            // Obtener la ruta completa del ejecutable de la aplicación
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Obtener el directorio donde se encuentra el ejecutable
            string exeDirectory = Path.GetDirectoryName(exePath);

            // Construir la ruta hacia la carpeta 'archivos'
            string archivosPath = Path.Combine(exeDirectory, "archivos");

            // Construir la ruta completa hacia el script específico dentro de la carpeta 'archivos'
            string scriptPath = Path.Combine(archivosPath, fileName);

            return scriptPath;
        }

        private void btReady_Click(object sender, EventArgs e)
        {
            bool todoOk = true;
            // Iterar sobre cada fase seleccionada en la lista de verificación
            foreach (string faseSeleccionada in clbFases.CheckedItems)
            {
                if (faseDict.TryGetValue(faseSeleccionada, out (string id, string idAnterior) faseInfo))
                {
                    string estadoFaseAnterior = GetEstadoFase(faseInfo.idAnterior);
                    var faseAnterior = faseDict.FirstOrDefault(x => x.Value.id == faseInfo.idAnterior).Key;
                    if (estadoFaseAnterior == "Pendiente")
                    {
                        MessageBox.Show($"La fase anterior '{faseAnterior}' aún está pendiente.");
                        continue;
                    }
                    string consulta = "SELECT ejecutable FROM Fase WHERE id = @id";
                    string ejecutableNombre = string.Empty; // Inicializar la variable donde almacenarás el nombre del ejecutable

                    using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
                    {
                        // Asegúrate de reemplazar el parámetro @id con el valor de faseInfo.id
                        command.Parameters.AddWithValue("@id", faseInfo.id);

                        // Ejecutar la consulta
                        object resultado = command.ExecuteScalar();

                        // Si hay un resultado, convertirlo a string y almacenarlo en ejecutableNombre
                        if (resultado != null)
                        {
                            ejecutableNombre = resultado.ToString();
                        }
                    }

                    string scriptPath = GetScriptPath(ejecutableNombre);
                    // Verificar si el archivo del script existe
                    if (!File.Exists(scriptPath))
                    {
                        MessageBox.Show($"El script {scriptPath} no existe.");
                        todoOk = false;
                        continue;
                    }

                    // Instancia de PowerShell para ejecutar el script
                    using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                        string script = File.ReadAllText(scriptPath);
                        PowerShellInstance.AddScript(script);
                        PowerShellInstance.AddCommand("Out-String");
                        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                        // Verificar si hubo errores durante la ejecución del script
                        if (PowerShellInstance.Streams.Error.Count > 0)
                        {
                            string errorMessage = "Errores encontrados al ejecutar el script:\n";
                            foreach (ErrorRecord error in PowerShellInstance.Streams.Error)
                            {
                                errorMessage += $"{error}\n";
                            }
                            MessageBox.Show(errorMessage);
                            todoOk = false;
                        }
                        else
                        {
                            // Actualizar el estado de la fase a 'Terminada' en la base de datos
                            string consulta1 = "UPDATE Fase SET estados = 'Terminada' WHERE id = @id";
                            using (SqlCommand command = new SqlCommand(consulta1, sessionManager.GetConnection()))
                            {
                                command.Parameters.AddWithValue("@id", faseInfo.id);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0 && clbFases.CheckedItems.Count == 1)
                                {
                                    MessageBox.Show($"Fase '{faseSeleccionada}' terminada");
                                }
                            }
                        }
                    }
                }
            }
            if (todoOk)
            {
                // Verificar si todas las fases están en estado 'terminada'
                string consultaVerificarFases = "SELECT COUNT(*) FROM Fase WHERE idTarea = @idTarea AND estados <> 'terminada'";
                using (SqlCommand commandVerificar = new SqlCommand(consultaVerificarFases, sessionManager.GetConnection()))
                {
                    commandVerificar.Parameters.AddWithValue("@idTarea", _id);
                    int fasesNoTerminadas = (int)commandVerificar.ExecuteScalar();

                    if (fasesNoTerminadas == 0)
                    {
                        // Si todas las fases están en estado 'terminada', actualizar el estado de la Tarea a 'Completada'
                        MessageBox.Show("Fases completadas!");
                        string consultaActualizarTarea = "UPDATE Tarea SET estado = 'Completada' WHERE id = @id";
                        using (SqlCommand commandActualizar = new SqlCommand(consultaActualizarTarea, sessionManager.GetConnection()))
                        {
                            commandActualizar.Parameters.AddWithValue("@id", _id);
                            commandActualizar.ExecuteNonQuery();
                        }
                    }

                }
            }
        }
        private string GetIdFaseAnterior(string faseId)
        {
            string consulta = "SELECT idAnterior FROM Fase WHERE id = @id";
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", faseId);
                return command.ExecuteScalar() as string;
            }
        }
        // Manejador del evento de clic en la lista de fases
        private void clbFases_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar si hay una fase seleccionada
            if (clbFases.SelectedItem != null)
            {
                string DescripcionSeleccionada = clbFases.SelectedItem.ToString();
                gbInfoFase.Visible = true;
                // Buscar la información de la fase seleccionada en el diccionario
                if (faseDict.TryGetValue(DescripcionSeleccionada, out (string id, string idAnterior) faseInfo))
                {
                    string idUsuario = GetIdUsuarioFromFase(faseInfo.id);
                    string nombreUsuario = GetNombreUsuario(idUsuario);
                    string fecha = GetFechaFromFase(faseInfo.id);
                    string descripcionFaseAnterior = GetDescripcionFaseAnterior(faseInfo.id);
                    string estadoFase = GetEstadoFase(faseInfo.id);

                    lUsuarioValor.Text = nombreUsuario;
                    lFaseAnteriorValor.Text = descripcionFaseAnterior;
                    lFechaValor.Text = fecha;
                    lEstadoValor.Text = estadoFase;
                }
            }
        }


        // Obtiene el ID del usuario asociado a una fase
        private string GetIdUsuarioFromFase(string faseId)
        {
            // Consulta SQL para obtener el ID del usuario
            string consulta = "SELECT idUsuario FROM Fase WHERE id = @id";
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", faseId);
                return command.ExecuteScalar() as string;
            }
        }
        // Obtiene el nombre del usuario a partir de su ID
        private string GetNombreUsuario(string idUsuario)
        {
            // Consulta SQL para obtener el nombre del usuario
            string consulta = "SELECT user_name FROM Usuarios WHERE id = @id";
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", idUsuario);
                return command.ExecuteScalar() as string;
            }
        }

        // Obtiene la fecha de inicio de una fase
        private string GetFechaFromFase(string faseId)
        {
            // Consulta SQL para obtener la fecha de inicio de la fase
            string consulta = "SELECT fecha_inicio FROM Fase WHERE id = @id";
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", faseId);
                object result = command.ExecuteScalar();
                return result != null ? (string)result : string.Empty;
            }
        }
        // Obtiene la descripción de la fase anterior a partir del ID de la fase actual
        private string GetDescripcionFaseAnterior(string faseId)
        {
            // Consulta SQL para obtener la descripción de la fase anterior
            string consulta = "SELECT descripcion FROM Fase WHERE id = (SELECT idAnterior FROM Fase WHERE id = @id)";
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                command.Parameters.AddWithValue("@id", faseId);
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }
        private string GetEstadoFase(string faseId)
        {
            // Verificar si faseId es null o una cadena vacía
            if (string.IsNullOrEmpty(faseId))
            {
                // Retornar un valor predeterminado o lanzar una excepción
                return "Estado desconocido"; // O manejar la situación de manera adecuada
            }

            string consulta = "SELECT estados FROM Fase WHERE id = @id";
            using (SqlCommand command = new SqlCommand(consulta, sessionManager.GetConnection()))
            {
                // Añadir el parámetro @id con el valor de faseId
                command.Parameters.AddWithValue("@id", faseId);

                // Ejecutar la consulta y obtener el resultado
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : "Estado no encontrado";
            }
        }


        // Manejador del evento click para el botón "Atrás"
        private void tbAtras_Click(object sender, EventArgs e)
        {
            TareasForm tareasForm = new TareasForm();
            tareasForm.Show();
            this.Close();
        }
        // Manejador del evento click para el botón "Crear"
        private void tbCrear_Click(object sender, EventArgs e)
        {
            NuevaFase nuevaFase = new NuevaFase(_id, this);
            nuevaFase.ShowDialog();
        }
        // Manejador del evento click para el botón "Eliminar"
        private void tbEliminar_Click(object sender, EventArgs e)
        {

            if (clbFases.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una fase para eliminar.");
                return;
            }
            // Mostrar un mensaje de error si se intentan eliminar varias fases a la vez
            if (clbFases.CheckedItems.Count > 1)
            {
                MessageBox.Show("Seleccione solo una fase para eliminar.");
                return;
            }
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta fase?", "", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }
            string selectedDescripcion = clbFases.SelectedItem.ToString();

            // Buscar la fase seleccionada en el diccionario de fases
            if (faseDict.TryGetValue(selectedDescripcion, out (string selectedId, string idAnterior) faseInfo))
            {
                // Consulta SQL para obtener el idAnterior de la fase seleccionada
                string queryGetIdAnterior = "SELECT idAnterior FROM Fase WHERE id = @id";
                string idAnterior = null;
                using (SqlCommand commandGetIdAnterior = new SqlCommand(queryGetIdAnterior, sessionManager.GetConnection()))
                {
                    commandGetIdAnterior.Parameters.AddWithValue("@id", faseInfo.selectedId);
                    using (SqlDataReader reader = commandGetIdAnterior.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idAnterior = reader["idAnterior"].ToString();
                        }
                    }
                }

                // Consulta SQL para eliminar la fase seleccionada
                string queryDelete = "DELETE FROM Fase WHERE id = @id";
                using (SqlCommand commandDelete = new SqlCommand(queryDelete, sessionManager.GetConnection()))
                {
                    // Agregar parámetro con el valor del id seleccionado
                    commandDelete.Parameters.AddWithValue("@id", faseInfo.selectedId);

                    // Ejecutar la consulta
                    int rowsAffected = commandDelete.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Actualizar el campo idAnterior de las fases que tenían la fase eliminada como anterior
                        string updateQuery = "UPDATE Fase SET idAnterior = @idAnterior WHERE idAnterior = @id";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, sessionManager.GetConnection()))
                        {
                            updateCommand.Parameters.AddWithValue("@id", faseInfo.selectedId);
                            updateCommand.Parameters.AddWithValue("@idAnterior", idAnterior ?? (object)DBNull.Value);
                            updateCommand.ExecuteNonQuery();
                        }

                        // Actualizar la lista de fases
                        clbFases.Items.Clear();

                        DatosFase();
                        clbFases.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la fase.");
                    }
                }
            }
        }
        // Manejador del evento click para el botón "Cambiar"
        private void tbCambiar_Click(object sender, EventArgs e)
        {
            ModificarFases modificarFases = new ModificarFases(_id);
            modificarFases.Show();

        }
        // Manejador del evento click para el botón "Volver"
        private void tbBack_Click(object sender, EventArgs e)
        {
            TareasForm tareasForm = new TareasForm();
            tareasForm.Show();
            this.Close();
        }

        private void tsExport_Click(object sender, EventArgs e)
        {
            // Definir la ruta del archivo PDF de salida
            string path = "FasesExportadas.pdf";

            // Crear un FileStream para escribir en el archivo
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                // Crear una instancia de Document
                using (Document document = new Document())
                {
                    // Asociar un PdfWriter al Document y al FileStream
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);

                    // Abrir el documento para la edición
                    document.Open();

                    // Añadir un párrafo por cada fase en clbFases
                    foreach (var item in clbFases.Items)
                    {
                        // Obtener la información de la fase
                        if (faseDict.TryGetValue(item.ToString(), out (string id, string idAnterior) faseInfo))
                        {
                            // Crear un párrafo con la descripción de la fase y añadirlo al documento
                            document.Add(new Paragraph(item.ToString()));

                            // Opcional: Añadir más información de cada fase si es necesario
                        }
                    }

                    // Cerrar el documento
                    document.Close();
                }
            }

            // Mostrar un mensaje al usuario indicando que el archivo se ha creado
            MessageBox.Show($"El documento PDF ha sido creado");

        }
    }
}



