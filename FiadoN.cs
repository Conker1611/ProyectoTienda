using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class FiadoN : Form
    {
        private decimal _totalDeuda;

        public FiadoN(decimal total)
        {
            InitializeComponent();
            _totalDeuda = total;
        }

        private void FiadoN_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingresa el nombre del cliente.");
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Fiados (Nombre, Fecha, Deuda) VALUES (@nombre, @fecha, @deuda)", con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmd.Parameters.AddWithValue("@deuda", _totalDeuda);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show($"Fiado registrado para {nombre}: S/ {_totalDeuda:F2}");
            this.Close();
        }

        private void btnFiar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingresa el nombre del cliente.");
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Fiados (Nombre, Fecha, Deuda) VALUES (@nombre, @fecha, @deuda)", con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmd.Parameters.AddWithValue("@deuda", _totalDeuda);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show($"Fiado registrado para {nombre}: S/ {_totalDeuda:F2}");
            this.Close();
        }
    }
}