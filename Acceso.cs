namespace ProyectoTienda
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
           if ( textusuario.Text == "1234" && textcontraseña.Text == "1234")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void Acceso_Load(object sender, EventArgs e)
        {
           
        }

        private void textcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
