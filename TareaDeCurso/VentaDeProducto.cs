using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDeCurso
{
    public partial class frmVentaDeProducto : Form
    {
        public frmVentaDeProducto()
        {
            InitializeComponent();
        }
        string[,] ListaProductos = new string[200,6];
        int f = 0;
        List<string> listaProductos = new List<string>();
        private void btnCargarLista_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtProducto.Text!=""&& txtCantidad.Text!=""&&txtEfectivo.Text!=""&& txtGenero.Text != "" && txtNombre.Text != "" && txtPrecio.Text != "" && txtTalla.Text != "" && txtTipo.Text != "")
                {

                    double precio= double.Parse(txtPrecio.Text);
                    double cantidad= double.Parse(txtCantidad.Text);
                    double subtotal= precio*cantidad;
                    ListaProductos[f,0]=txtProducto.Text;
                    ListaProductos[f,1]=txtNombre.Text;
                    ListaProductos[f,2]=txtPrecio.Text;
                    ListaProductos[f,3]=txtTalla.Text;
                    ListaProductos[f,4]=txtTipo.Text;
                    ListaProductos[f,5]=txtGenero.Text;
                    ListaProductos[f,6]=txtCantidad.Text;
                    ListaProductos[f, 7] = subtotal.ToString("C");
                    //foreach(var lista in ListaProductos)
                    //    listaProductos.Add(lista);
                    
                    foreach(var producto in listaProductos)
                        dgvLista.Rows.Add(producto);
                    f++;


                    txtProducto.Clear();
                    txtCantidad.Clear();
                    txtEfectivo.Clear();
                    txtGenero.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtTalla.Clear();
                    txtTipo.Clear();


                }


            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
