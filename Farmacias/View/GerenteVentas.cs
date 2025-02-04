using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacias
{
    public partial class GerenteVentas : Form
    {
        
        string nombemp, idsucursal, idempleado, idalmacen, nomfarmacia;
        Connections cx = new Connections();
        public GerenteVentas()
        {
            InitializeComponent();
        }
        public GerenteVentas(string a, string b, string c, string d, string e)
        {
            nombemp = a; idsucursal = b; idempleado = c; idalmacen = d; nomfarmacia = e;
            InitializeComponent();
            
        }

        private void GerenteVentas_Load(object sender, EventArgs e)
        {
            cx = new Connections(this);//aqui es donde le mandas la info al constructor , solo ocupas invocar una vez
            cx.VentasTotales(int.Parse(idsucursal));
            cx.cbx1(idsucursal,idempleado);
            timer1.Start();
            Empleado.Text = nombemp;
            
            cbTipo.Items.Add("Mes");
            cbTipo.Items.Add("Dia");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void labelNomFarma_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void cbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Connections cx = new Connections(this);
                cx.VentasVendedor(int.Parse(idsucursal), int.Parse(cbVendedor.Text));
            }
            catch { }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.Text == "Mes")
                {
                    dtfecha.Visible = false;
                    cbMes.Visible = true;
                    //Connections cx = new Connections(this);
                    cx.Meses();
                }
                else if (cbTipo.Text == "Dia")
                {
                    dtfecha.Visible = true;
                    cbMes.Visible = false;
                }
            }
            catch (Exception a) { MessageBox.Show(a.Message.ToString()); }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Singleton.Instance.OpenDBConnection();

                SqlDataAdapter ada = new SqlDataAdapter(string.Format("SELECT factura.idfactura, factura.fecha, factura.total, factura.idempleado FROM factura, empleados, sucursal WHERE MONTH(factura.fecha)={0} AND empleados.idempleado=factura.idempleado AND empleados.idsucursal=sucursal.idsucursal AND sucursal.idsucursal={1}", int.Parse(cbMes.Text), int.Parse(idsucursal)), Singleton.Instance.GetDBConnection());
                DataSet dat = new DataSet();
                ada.Fill(dat, "Ventas Mes");
                dataFecha.DataSource = dat;
                dataFecha.DataMember = "Ventas Mes";

                Singleton.Instance.GetDBConnection().Close();

                int total = 0;
                foreach (DataGridViewRow Celda in dataFecha.Rows)
                {
                    if (Celda.Cells[2].Value != null && Celda.Cells[2].Value.ToString() != "")
                    {
                        int valorCelda;
                        if (int.TryParse(Celda.Cells[2].Value.ToString(), out valorCelda))
                        {
                            total += valorCelda;
                        }
                    }
                }
                lblVF.Text = total.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
        }


        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Singleton.Instance.OpenDBConnection();

                SqlDataAdapter ada = new SqlDataAdapter(string.Format("SELECT factura.idfactura, factura.fecha, factura.total, factura.idempleado FROM factura, empleados, sucursal WHERE factura.fecha='{0}' AND empleados.idempleado=factura.idempleado AND empleados.idsucursal=sucursal.idsucursal AND sucursal.idsucursal={1}", dtfecha.Value.ToShortDateString(), idsucursal), Singleton.Instance.GetDBConnection());
                DataSet dat = new DataSet();
                ada.Fill(dat, "Ventas Dia");
                dataFecha.DataSource = dat;
                dataFecha.DataMember = "Ventas Dia";

                Singleton.Instance.GetDBConnection().Close();

                int total = 0;
                foreach (DataGridViewRow Celda in dataFecha.Rows)
                {
                    if (Celda.Cells[2].Value != null && Celda.Cells[2].Value.ToString() != "")
                    {
                        int valorCelda;
                        if (int.TryParse(Celda.Cells[2].Value.ToString(), out valorCelda))
                        {
                            total += valorCelda;
                        }
                    }
                }
                lblVF.Text = total.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
        }
    }
}
