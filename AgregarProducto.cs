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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            this.CancelButton = btncancelar1;
        }

        private void btncancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Completar todo los datos");
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Productos (Codigo, Nombre, Precio, Stock) VALUES (@codigo, @nombre, @precio, @stock)", con);

            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
            cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Producto agregado");
            this.Close();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}