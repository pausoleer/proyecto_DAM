using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowProject
{
    public class SessionManager
    {
        private static SessionManager instance;
        private SqlConnection connection;

        private SessionManager()
        {
            // Cadena de conexión a la base de datos
            string connectionString = "server=(localdb)\\Local;database=Workflow_database; integrated security=true";
            // Inicializa la conexión
            connection = new SqlConnection(connectionString);
        }

        // Método estático para obtener la instancia única de la clase
        // Si la instancia no existe, se crea
        public static SessionManager GetInstance()
        {
            if (instance == null)
            {
                instance = new SessionManager();
            }
            return instance;
        }

        // Método para obtener la conexión
        public SqlConnection GetConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        // Método para cerrar la conexión
        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        // Propiedad para almacenar el ID del equipo del usuario actual
        public string IdEquipoUsuario { get; set; }
        // Propiedad para determinar si el usuario actual es administrador
        public bool IsAdmin { get; set; }
    }
}
