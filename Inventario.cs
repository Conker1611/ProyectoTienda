using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoTienda
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            this.CancelButton = btnatras;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
        }

        private void CargarProductos(string filtro = "")
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM Productos WHERE Nombre LIKE @filtro", con);
            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProductos.DataSource = dt;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            dgvProductos.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvProductos.CurrentRow;
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            string codigo = fila.Cells["Codigo"].Value.ToString();
            string nombre = fila.Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
            int stock = Convert.ToInt32(fila.Cells["Stock"].Value);

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE Productos SET Codigo=@codigo, Nombre=@nombre, Precio=@precio, Stock=@stock WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dgvProductos.ReadOnly = true;
            MessageBox.Show("Producto actualizado");
        }
    }
}