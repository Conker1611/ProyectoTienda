using MySql.Data.MySqlClient;

namespace ProyectoTienda
{
    internal class Conexion
    {
        private static string cadena = "Server=zephyr.proxy.rlwy.net;Port=21449;Database=railway;Uid=root;Pwd=unzPghoQMNOlBrnDUrWKFAVsdyLmKnRR;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}