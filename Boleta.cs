using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Boleta : Form
    {
        private DataGridView productos;
        private decimal total;
        private string nombreCliente;

        public Boleta(DataGridView productos, decimal total)
        {
            InitializeComponent();
            this.productos = productos;
            this.total = total;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Ingresa el nombre del cliente");
                return;
            }

            nombreCliente = txtNombreCliente.Text;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Imprimir);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);

            int y = 20;
            int x = 20;

            // Titulo
            g.DrawString("BOLETA DE VENTA", fontTitulo, Brushes.Black, x, y);
            y += 30;
            g.DrawString("Cliente: " + nombreCliente, fontNormal, Brushes.Black, x, y);
            y += 20;
            g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontNormal, Brushes.Black, x, y);
            y += 30;

            // Encabezado tabla
            g.DrawString("Producto", fontBold, Brushes.Black, x, y);
            g.DrawString("Precio", fontBold, Brushes.Black, x + 200, y);
            y += 20;
            g.DrawLine(Pens.Black, x, y, x + 300, y);
            y += 10;

            // Productos
            foreach (DataGridViewRow fila in productos.Rows)
            {
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string precio = fila.Cells["Precio"].Value.ToString();
                g.DrawString(nombre, fontNormal, Brushes.Black, x, y);
                g.DrawString(precio, fontNormal, Brushes.Black, x + 200, y);
                y += 20;
            }

            // Total
            y += 10;
            g.DrawLine(Pens.Black, x, y, x + 300, y);
            y += 10;
            g.DrawString("TOTAL: S/ " + total.ToString("0.00"), fontBold, Brushes.Black, x, y);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Boleta_Load(object sender, EventArgs e)
        {

        }
    }
}