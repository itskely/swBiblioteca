using Microsoft.Data.SqlClient;

namespace swBiblioteca.Datos
{
    public class Conexion
    {
        private string cadenaConexion =
            @"Server=.\DESARROLLO;Database=Biblioteca;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

    }
}
