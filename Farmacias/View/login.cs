using Service.Jwt;
using System;
using System.Windows.Forms;
using Farmacias.View;
using Farmacias.Service.Jwt;


namespace Farmacias
{
    public partial class Login : Form
    {
        private Connections cx;
        public string nombre, idsucursal, idempleado, idalmacen, nombrefar;

        //empleados.nombre,empleados.idsucursal,almacen.idalmacen
        private string u, p;

        public Login()
        {
            InitializeComponent();
        }
        public void ResetLoginFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        #region design :D

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.unlock;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._lock;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                u = textBox1.Text;
                p = textBox2.Text;
                cx = new Connections(this);
                JwtService jwtService = new JwtService();

                string rol = cx.Login(u, p);

                if (rol == "1") 
                {
                    Gerente gerenteForm = new Gerente(nombre, idsucursal, idempleado, idalmacen, nombrefar);
                    gerenteForm.Owner = this;
                    gerenteForm.Show();
                    this.Hide();
                }
                else if (rol == "2")
                {
                    Vendedor vendedorForm = new Vendedor(nombre, idsucursal, idempleado, idalmacen, nombrefar);
                    vendedorForm.Owner = this;
                    vendedorForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El servicio de autenticación no está disponible. (Error en el servicio de mensajería)");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        #endregion design :D
    }
}