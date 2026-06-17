using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarVentasDelDia();
            CargarStockBajo();
        }

        private void CargarVentasDelDia()
        {
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add("Hora", "Hora");
            dgvVentas.Columns.Add("Productos", "Productos");
            dgvVentas.Columns.Add("Total", "Total");

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT v.Fecha, 
                       GROUP_CONCAT(d.NombreProducto SEPARATOR ', ') AS Productos,
                       v.Total
                FROM Ventas v
                JOIN DetalleVentas d ON v.Id = d.VentaId
                WHERE DATE(v.Fecha) = CURDATE()
                GROUP BY v.Id", con);

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dgvVentas.Rows.Add(
                    Convert.ToDateTime(reader["Fecha"]).ToString("HH:mm"),
                    reader["Productos"].ToString(),
                    "S/ " + Convert.ToDecimal(reader["Total"]).ToString("0.00")
                );
            }

            con.Close();
        }

        private void CargarStockBajo()
        {
            dgvStockBajo.Rows.Clear();
            dgvStockBajo.Columns.Clear();

            dgvStockBajo.Columns.Add("Nombre", "Producto");
            dgvStockBajo.Columns.Add("Stock", "Stock");

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT Nombre, Stock FROM Productos WHERE Stock <= 5 ORDER BY Stock ASC", con);

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int stock = Convert.ToInt32(reader["Stock"]);
                int fila = dgvStockBajo.Rows.Add(
                    reader["Nombre"].ToString(),
                    stock
                );

                if (stock == 0)
                {
                    dgvStockBajo.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    dgvStockBajo.Rows[fila].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    dgvStockBajo.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                }
            }

            con.Close();
        }
    }
}