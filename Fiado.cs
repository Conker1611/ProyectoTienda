using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Fiado : Form
    {
        public Fiado()
        {
            InitializeComponent();
        }

        private void Fiado_Load(object sender, EventArgs e)
        {
            CargarFiados();
        }

        private void CargarFiados()
        {
            dgvFiados.Rows.Clear();
            dgvFiados.Columns.Clear();

            // Columnas de datos
            dgvFiados.Columns.Add("Id", "ID");
            dgvFiados.Columns["Id"].Visible = false;
            dgvFiados.Columns.Add("Nombre", "Cliente");
            dgvFiados.Columns.Add("Fecha", "Fecha");
            dgvFiados.Columns.Add("Deuda", "Deuda");

            // Botón eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "¿Pagó?";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvFiados.Columns.Add(btnEliminar);

            // Cargar desde MySQL
            MySqlConnection con = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT Id, Nombre, Fecha, Deuda FROM Fiados", con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dgvFiados.Rows.Add(
                    reader["Id"].ToString(),
                    reader["Nombre"].ToString(),
                    Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy"),
                    "S/ " + Convert.ToDecimal(reader["Deuda"]).ToString("0.00")
                );
            }

            con.Close();

            // Conectar el evento CellClick por código
            dgvFiados.CellClick += dgvFiados_CellClick;
        }

        private void dgvFiados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFiados.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                string nombre = dgvFiados.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? "";
                string id = dgvFiados.Rows[e.RowIndex].Cells["Id"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(id)) return; // por si acaso

                DialogResult confirm = MessageBox.Show(
                    $"¿ Se eliminará el fiado.",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    MySqlConnection con = Conexion.ObtenerConexion();
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM Fiados WHERE Id = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Fiado eliminado.");
                    CargarFiados();
                }
            }
        }
    }
}