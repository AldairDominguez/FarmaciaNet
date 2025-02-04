using NUnit.Framework;
using System;
using System.Windows.Forms;
using Farmacias;

namespace TestFarmacias
{
    [TestFixture]
    public class VendedorTest
    {
        private Vendedor _formularioVendedor;
        private ToolStripMenuItem _menuInventario;
        private ToolStripMenuItem _menuProducto;
        private ToolStripButton _botonVentas;
        private MenuStrip _barraMenu;

        [SetUp]
        public void ConfiguracionInicial()
        {
            _formularioVendedor = new Vendedor("nombre", "ids", "ide", "ida", "nombrefar")
            {
                IsMdiContainer = true 
            };

            _barraMenu = new MenuStrip();
            _menuInventario = new ToolStripMenuItem { Name = "menuInventario", Text = "Inventario" };
            _menuProducto = new ToolStripMenuItem { Name = "menuProducto", Text = "Producto" };

 
            _menuInventario.Click += (sender, e) =>
            {
                _formularioVendedor.GetType()
                    .GetMethod("inventarioToolStripMenuItem_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.Invoke(_formularioVendedor, new object[] { sender, e });
            };

            _menuProducto.Click += (sender, e) =>
            {
                _formularioVendedor.GetType()
                    .GetMethod("productoToolStripMenuItem_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.Invoke(_formularioVendedor, new object[] { sender, e });
            };

            _barraMenu.Items.Add(_menuInventario);
            _barraMenu.Items.Add(_menuProducto);

            _formularioVendedor.Controls.Add(_barraMenu);

            _botonVentas = new ToolStripButton { Name = "botonVentas", Text = "Ventas" };

            var barraHerramientas = new ToolStrip();
            barraHerramientas.Items.Add(_botonVentas);

            _botonVentas.Click += (sender, e) =>
            {
                _formularioVendedor.GetType()
                    .GetMethod("toolStripButton1_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.Invoke(_formularioVendedor, new object[] { sender, e });
            };

            _formularioVendedor.Controls.Add(barraHerramientas);
        }

        [Test]
        public void Vendedor_Load_DeberiaEstablecerEsContenedorMdi()
        {
            _formularioVendedor.GetType()
                .GetMethod("Vendedor_Load", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(_formularioVendedor, new object[] { null, EventArgs.Empty });

            Assert.That(_formularioVendedor.IsMdiContainer, Is.True, "El formulario debería ser un contenedor MDI.");
        }

        [Test]
        public void BotonVentas_Click_DeberiaMostrarFormularioVentas()
        {
            _botonVentas.PerformClick();

            Assert.That(_formularioVendedor.MdiChildren.Length, Is.GreaterThan(0), "No se abrió ningún formulario hijo.");
            var formularioHijo = _formularioVendedor.MdiChildren[0];
            Assert.That(formularioHijo is Ventas, Is.True, "Debería abrirse el formulario Ventas.");
        }

        [Test]
        public void Vendedor_FormClosing_DeberiaReiniciarCamposDelLogin()
        {
            var loginMock = new Login();
            _formularioVendedor.Owner = loginMock;

            _formularioVendedor.GetType()
                .GetMethod("Vendedor_FormClosing", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(_formularioVendedor, new object[] { null, new FormClosingEventArgs(CloseReason.UserClosing, false) });

            Assert.That(loginMock.Visible, Is.True, "El formulario de Login debería ser visible después de cerrar Vendedor.");
        }
    }
}
