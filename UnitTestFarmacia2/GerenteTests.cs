using NUnit.Framework;
using Farmacias;
using System.Windows.Forms;
using System;

namespace TestFarmacias
{
    [TestFixture]
    public class GerenteTests
    {
        private Gerente _formularioGerente;

        [SetUp]
        public void ConfiguracionInicial()
        {
            _formularioGerente = new Gerente("nombre", "idsucursal", "idempleado", "idalmacen", "nombrefarmacia");
        }

        [Test]
        public void AgregarEmpleado_DeberiaAbrirFormaXConGrupoAddEmpVisible()
        {
            try
            {
                _formularioGerente.Show();
                Application.DoEvents();

                _formularioGerente.GetType()
                    .GetMethod("agregarToolStripMenuItem2_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.Invoke(_formularioGerente, new object[] { null, EventArgs.Empty });

                Assert.That(_formularioGerente.MdiChildren.Length, Is.GreaterThan(0), "No se abrió ningún formulario hijo.");
                var formularioHijo = _formularioGerente.MdiChildren[0];

                Assert.That(formularioHijo is Forma_X, Is.True, "Debería abrirse Forma_X.");
                var formaX = (Forma_X)formularioHijo;

                Assert.That(formaX.groupAddEmp, Is.Not.Null, "El grupo groupAddEmp no debería ser nulo.");

                Assert.That(formaX.groupAddEmp.Visible, Is.True, "El grupo de agregar empleado debería ser visible.");
            }
            finally
            {
                foreach (var child in _formularioGerente.MdiChildren)
                {
                    child.Close();
                    child.Dispose();
                }

                _formularioGerente.Close();
                _formularioGerente.Dispose();
            }
        }

        [Test]
        public void AgregarInventario_DeberiaAbrirFormaXConGrupoAddInventarioVisible()
        {
            try
            {

                _formularioGerente.Show();
                Application.DoEvents();

                _formularioGerente.GetType()
                    .GetMethod("agregarToolStripMenuItem1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.Invoke(_formularioGerente, new object[] { null, EventArgs.Empty });

                Assert.That(_formularioGerente.MdiChildren.Length, Is.GreaterThan(0), "No se abrió ningún formulario hijo.");
                var formularioHijo = _formularioGerente.MdiChildren[0];

                Assert.That(formularioHijo is Forma_X, Is.True, "Debería abrirse Forma_X.");
                var formaX = (Forma_X)formularioHijo;
                Assert.That(formaX.groupAddInventario, Is.Not.Null, "El control groupAddInventario no debería ser nulo.");
                Assert.That(formaX.groupAddInventario.Visible, Is.True, "El grupo de agregar inventario debería ser visible.");
            }
            finally
            {
                foreach (var child in _formularioGerente.MdiChildren)
                {
                    child.Close();
                    child.Dispose();
                }

                _formularioGerente.Close();
                _formularioGerente.Dispose();
            }
        }

        [Test]
        public void ConsultarInventario_DeberiaAbrirFormaConsultasConGrupoCInvVisible()
        {
            try
            {

                _formularioGerente.Show();
                Application.DoEvents();
                _formularioGerente.GetType()
                    .GetMethod("inventarioDeProductosToolStripMenuItem_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.Invoke(_formularioGerente, new object[] { null, EventArgs.Empty });

                Assert.That(_formularioGerente.MdiChildren.Length, Is.GreaterThan(0), "No se abrió ningún formulario hijo.");
                var formularioHijo = _formularioGerente.MdiChildren[0];

                Assert.That(formularioHijo is Forma_Consultas, Is.True, "Debería abrirse Forma_Consultas.");
                var formaConsultas = (Forma_Consultas)formularioHijo;
                Assert.That(formaConsultas.groupCInv, Is.Not.Null, "El control groupCInv no debería ser nulo.");
                Assert.That(formaConsultas.groupCInv.Visible, Is.True, "El grupo de consultas de inventario debería ser visible.");
            }
            finally
            {
                foreach (var child in _formularioGerente.MdiChildren)
                {
                    child.Close();
                    child.Dispose();
                }

                _formularioGerente.Close();
                _formularioGerente.Dispose();
            }
        }

        [Test]
        public void Gerente_FormClosing_DeberiaReiniciarCamposDeLogin()
        {
            var loginMock = new Login();
            _formularioGerente.Owner = loginMock;
            _formularioGerente.GetType()
                .GetMethod("Gerente_FormClosing", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(_formularioGerente, new object[] { null, new FormClosingEventArgs(CloseReason.UserClosing, false) });
            Assert.That(loginMock.Visible, Is.True, "El formulario de Login debería ser visible después de cerrar Gerente.");
        }
    }
}
