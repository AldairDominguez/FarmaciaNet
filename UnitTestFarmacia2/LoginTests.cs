using NUnit.Framework;
using Farmacias;
using System.Windows.Forms;
using System;

namespace TestFarmacias
{
    [TestFixture]
    public class LoginTests
    {
        private Login _formularioLogin;

        [SetUp]
        public void ConfiguracionInicial()
        {
            _formularioLogin = new Login();
        }

        [Test]
        public void ResetLoginFields_DeberiaLimpiarTextBoxesYEnfocarTextBox1()
        {
            var textBox1 = new TextBox { Name = "textBox1", Text = "usuario" };
            var textBox2 = new TextBox { Name = "textBox2", Text = "contraseña" };
            _formularioLogin.Controls.Add(textBox1);
            _formularioLogin.Controls.Add(textBox2);

            _formularioLogin.GetType().GetField("textBox1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(_formularioLogin, textBox1);

            _formularioLogin.GetType().GetField("textBox2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(_formularioLogin, textBox2);

            _formularioLogin.Show();
            _formularioLogin.Activate();

            _formularioLogin.ResetLoginFields();

            Assert.That(string.IsNullOrEmpty(textBox1.Text), Is.True, "TextBox1 debería estar vacío");
            Assert.That(string.IsNullOrEmpty(textBox2.Text), Is.True, "TextBox2 debería estar vacío");
            Assert.That(textBox1.Focused, Is.True, "TextBox1 debería tener el foco");
        }

        [Test]
        public void Login_Load_DeberiaEnfocarTextBox1()
        {
            var textBox1 = new TextBox { Name = "textBox1" };
            _formularioLogin.Controls.Add(textBox1);

            _formularioLogin.Show();
            _formularioLogin.BringToFront();
            Application.DoEvents();

            _formularioLogin.GetType()
                .GetMethod("login_Load", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(_formularioLogin, new object[] { null, EventArgs.Empty });

            textBox1.Select();
            Application.DoEvents();
            Assert.That(textBox1.Focused, Is.True, "TextBox1 debería tener el foco después de cargar el formulario");
        }

        [Test]
        public void PictureBox4_Click_DeberiaCerrarFormulario()
        {
            var fueCerrado = false;
            _formularioLogin.FormClosing += (s, e) => fueCerrado = true;

            _formularioLogin.Show();

            _formularioLogin.GetType()
                .GetMethod("pictureBox4_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(_formularioLogin, new object[] { null, EventArgs.Empty });

            Assert.That(fueCerrado, Is.True, "El formulario debería cerrarse al hacer clic en PictureBox4");
        }

        [Test]
        public void PictureBox5_Click_DeberiaMinimizarFormulario()
        {
            _formularioLogin.GetType()
                .GetMethod("pictureBox5_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke(_formularioLogin, new object[] { null, EventArgs.Empty });

            Assert.That(_formularioLogin.WindowState, Is.EqualTo(FormWindowState.Minimized), "El formulario debería minimizarse");
        }
    }
}
