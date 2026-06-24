using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Caja : Form
    {
        decimal total = 0;
        public Caja()
        {
            InitializeComponent();
            this.CancelButton = btnatras;
            dgvCaja.AllowUserToAddRows = false;
            dgvCaja.ReadOnly = true;
            dgvCaja.Columns.Add("Nombre", "Nombre");
            dgvCaja.Columns.Add("Precio", "Precio");
            dgvCaja.Columns.Add("Codigo", "Codigo");
            dgvCaja.Columns["Codigo"].Visible = false;
            buscadorbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            buscadorbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CargarAutocompletado();
        }

        private void CargarAutocompletado()
        {
            AutoCompleteStringCollection nombres = new AutoCompleteStringCollection();
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT Nombre FROM Productos", con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nombres.Add(reader["Nombre"].ToString());
            }
            con.Close();
            buscadorbox.AutoCompleteCustomSource = nombres;
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dgvCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string busqueda = buscadorbox.Text;
            if (busqueda == "") return;

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT Nombre, Precio, Codigo FROM Productos WHERE Codigo = @busqueda OR Nombre = @nombre", con);
            cmd.Parameters.AddWithValue("@busqueda", busqueda);
            cmd.Parameters.AddWithValue("@nombre", busqueda);

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nombre = reader["Nombre"].ToString();
                decimal precio = Convert.ToDecimal(reader["Precio"]);
                string codigo = reader["Codigo"].ToString();
                dgvCaja.Rows.Add(nombre, "S/ " + precio.ToString("0.00"), codigo);
                total += precio;
                lblTotal.Text = "TOTAL: S/ " + total.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
            con.Close();
            buscadorbox.Text = "";
            buscadorbox.Focus();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                decimal vuelto = monto - total;
                lblVuelto.Text = "Vuelto: S/ " + vuelto.ToString("0.00");
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvCaja.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos agregados");
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            con.Open();

            // 1. Insertar venta y obtener su Id
            MySqlCommand cmdVenta = new MySqlCommand(
                "INSERT INTO Ventas (Fecha, Total) VALUES (@fecha, @total); SELECT LAST_INSERT_ID();", con);
            cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmdVenta.Parameters.AddWithValue("@total", total);
            int ventaId = Convert.ToInt32(cmdVenta.ExecuteScalar());

            // 2. Por cada producto insertar detalle y descontar stock
            foreach (DataGridViewRow fila in dgvCaja.Rows)
            {
                string codigo = fila.Cells["Codigo"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string precioTexto = fila.Cells["Precio"].Value.ToString().Replace("S/ ", "");
                decimal precio = Convert.ToDecimal(precioTexto);

                MySqlCommand cmdDetalle = new MySqlCommand(
                    "INSERT INTO DetalleVentas (VentaId, NombreProducto, Precio) VALUES (@ventaId, @nombre, @precio)", con);
                cmdDetalle.Parameters.AddWithValue("@ventaId", ventaId);
                cmdDetalle.Parameters.AddWithValue("@nombre", nombre);
                cmdDetalle.Parameters.AddWithValue("@precio", precio);
                cmdDetalle.ExecuteNonQuery();

                MySqlCommand cmdStock = new MySqlCommand(
                    "UPDATE Productos SET Stock = Stock - 1 WHERE Codigo = @codigo", con);
                cmdStock.Parameters.AddWithValue("@codigo", codigo);
                cmdStock.ExecuteNonQuery();
            }

            con.Close();

            dgvCaja.Rows.Clear();
            total = 0;
            lblTotal.Text = "TOTAL: S/ 0.00";
            txtMonto.Clear();
            lblVuelto.Text = "Vuelto:";

            MessageBox.Show("Cobro realizado");
        }

        private void Caja_Load(object sender, EventArgs e)
        {
        }

        private void buscadorbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnImpresion_Click(object sender, EventArgs e)
        {
            if (dgvCaja.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos agregados");
                return;
            }
            Boleta boleta = new Boleta(dgvCaja, total);
            boleta.ShowDialog();
        }


        private void btnFiado_Click(object sender, EventArgs e)
        {
            if (dgvCaja.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos agregados.");
                return;
            }

            FiadoN fiado = new FiadoN(total);
            fiado.ShowDialog();

            if (fiado.FiadoGuardado)
            {
                MySqlConnection con = Conexion.ObtenerConexion();
                con.Open();

                // Registrar en Ventas como FIADO
                MySqlCommand cmdVenta = new MySqlCommand(
                    "INSERT INTO Ventas (Fecha, Total) VALUES (@fecha, @total); SELECT LAST_INSERT_ID();", con);
                cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmdVenta.Parameters.AddWithValue("@total", total);
                int ventaId = Convert.ToInt32(cmdVenta.ExecuteScalar());

                foreach (DataGridViewRow fila in dgvCaja.Rows)
                {
                    string codigo = fila.Cells["Codigo"].Value.ToString();
                    string nombre = fila.Cells["Nombre"].Value.ToString();
                    string precioTexto = fila.Cells["Precio"].Value.ToString().Replace("S/ ", "");
                    decimal precio = Convert.ToDecimal(precioTexto);

                    // Registrar detalle
                    MySqlCommand cmdDetalle = new MySqlCommand(
                        "INSERT INTO DetalleVentas (VentaId, NombreProducto, Precio) VALUES (@ventaId, @nombre, @precio)", con);
                    cmdDetalle.Parameters.AddWithValue("@ventaId", ventaId);
                    cmdDetalle.Parameters.AddWithValue("@nombre", nombre);
                    cmdDetalle.Parameters.AddWithValue("@precio", precio);
                    cmdDetalle.ExecuteNonQuery();

                    // Descontar stock
                    MySqlCommand cmdStock = new MySqlCommand(
                        "UPDATE Productos SET Stock = Stock - 1 WHERE Codigo = @codigo", con);
                    cmdStock.Parameters.AddWithValue("@codigo", codigo);
                    cmdStock.ExecuteNonQuery();
                }

                con.Close();

                dgvCaja.Rows.Clear();
                total = 0;
                lblTotal.Text = "TOTAL: S/ 0.00";
                txtMonto.Clear();
                lblVuelto.Text = "Vuelto:";
            }
        }
    }
    
}