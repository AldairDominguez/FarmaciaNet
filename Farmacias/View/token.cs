using Service.Jwt;
using System;
using System.Security.Claims;
using System.Windows.Forms;

namespace Farmacias.View
{
    public partial class TokenForm : Form
    {
        private Timer timer;
        private TimeSpan tiempoRestante;
        private JwtService jwtService;
        public string nombre, idsucursal, idempleado, idalmacen, nombrefar;

        private void TokenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is Login loginForm)
            {
                loginForm.ResetLoginFields();
                loginForm.Show();
            }
        }

        public TokenForm(string nombre, string idsucursal, string idempleado, string idalmacen, string nombrefar)
        {
            InitializeComponent();
            jwtService = new JwtService();

            this.nombre = nombre;
            this.idsucursal = idsucursal;
            this.idempleado = idempleado;
            this.idalmacen = idalmacen;
            this.nombrefar = nombrefar;

            IniciarTemporizador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string token = txtValidacion.Text;
            ClaimsPrincipal principal = jwtService.ValidateToken(token);

            if (principal != null)
            {
                var roleClaim = principal.FindFirst(ClaimTypes.Role);
                if (roleClaim != null)
                {
                    string role = roleClaim.Value;

                    if (role == "1")
                    {
                        Gerente gerenteForm = new Gerente(nombre, idsucursal, idempleado, idalmacen, nombrefar);
                        gerenteForm.Owner = this.Owner;
                        this.Owner = gerenteForm;
                        gerenteForm.Show();
                        this.Hide();
                    }
                    else if (role == "2")
                    {
                        Vendedor vendedorForm = new Vendedor(nombre, idsucursal, idempleado, idalmacen, nombrefar);
                        vendedorForm.Owner = this.Owner;
                        this.Owner = vendedorForm;
                        vendedorForm.Show();
                        this.Hide();
                    }
                    this.Hide();
                    timer.Stop();
                }
                else
                {
                    MessageBox.Show("Rol no válido en el token.");
                }
            }
            else
            {
                MessageBox.Show("Token no válido.");
            }
            
        }

        public void txtToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void IniciarTemporizador()
        {
            // Tiempo inicial de 2 minutos
           // tiempoRestante = TimeSpan.FromMinutes(1);
            tiempoRestante = TimeSpan.FromSeconds(30);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            txtTime.Text = tiempoRestante.ToString(@"mm\:ss");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromSeconds(1));
            txtTime.Text = tiempoRestante.ToString(@"mm\:ss");

            if (tiempoRestante.TotalSeconds <= 0)
            {
                timer.Stop();
                MessageBox.Show("El tiempo ha expirado. Regresando a Login...", "Tiempo Expirado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.Owner is Login loginForm)
                {
                    loginForm.ResetLoginFields(); 
                    loginForm.Show();       
                }
                else
                {
                    Login newLoginForm = new Login();
                    newLoginForm.Show();
                }

                this.Close();
            }
        }
    }
}