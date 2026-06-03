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
            string busqueda = txtBuscar.Text;
            if (busqueda == "") return;

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT Nombre, Precio FROM Productos WHERE Codigo = @busqueda", con);
            cmd.Parameters.AddWithValue("@busqueda", busqueda);

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nombre = reader["Nombre"].ToString();
                decimal precio = Convert.ToDecimal(reader["Precio"]);
                dgvCaja.Rows.Add(nombre, "S/ " + precio.ToString("0.00"), busqueda);
                total += precio;
                lblTotal.Text = "TOTAL: S/ " + total.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
            con.Close();
            txtBuscar.Clear();
            txtBuscar.Focus();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                decimal vuelto = monto - total;
                lblVuelto.Text = "Vuelto: S/ " + vuelto.ToString("0.00");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

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

            foreach (DataGridViewRow fila in dgvCaja.Rows)
            {
                string codigo = fila.Cells["Codigo"].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE Productos SET Stock = Stock - 1 WHERE Codigo = @codigo", con);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
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
    }
}