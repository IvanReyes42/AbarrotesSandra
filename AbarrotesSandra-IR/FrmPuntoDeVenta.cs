using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using Manejadores;
using Entidades;
using System.Drawing.Printing;

namespace AbarrotesSandra_IR
{
    public partial class FrmPuntoDeVenta : Form
    {
        ManejadorPuntoDeVenta mpv = new ManejadorPuntoDeVenta();
        int IdProducto = 0, posicion = 0,contador =0;
        double PrecioProducto = 0.0, total = 0.0;
        List<ListaProductos> lp = new List<ListaProductos>();
        string ruta= "";
       
        public FrmPuntoDeVenta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal.op = 0;
            Close();
        }

        private void FrmPuntoDeVenta_Load(object sender, EventArgs e)
        {
            LlenarData("");
            LlenarImpresoras();
            //LlenarDataTicket();
        }
        public void LlenarImpresoras()
        {
            string printers;
            cmbImpresoras.Items.Add("Guardar Archivo"); 
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                printers = PrinterSettings.InstalledPrinters[i];
                cmbImpresoras.Items.Add(printers);
            }
            
        }
        public void LlenarData(string Nombre)
        {
            try
            {
                dgvProductos.DataSource = mpv.ListasProductos(Nombre).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error al llenar los datos");
            }
        }

        private void txtProductoBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarData(txtProductoBusqueda.Text);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = e.RowIndex;
                IdProducto = int.Parse(dgvProductos.Rows[fila].Cells[0].Value.ToString());
                txtProductoDetalle.Text = dgvProductos.Rows[fila].Cells[1].Value.ToString();
                PrecioProducto = double.Parse(dgvProductos.Rows[fila].Cells[2].Value.ToString());

                grupoProducto.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al selecionar un producto");
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarGrupo();
        }
        public void LimpiarGrupo()
        {
            grupoProducto.Enabled = false;
            txtCantidad.Text = "1";
            txtProductoDetalle.Clear();
            PrecioProducto = 0.0;
            IdProducto = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text.Length > 0)
                {
                    ListaProductos p = new ListaProductos();
                    p.IdProducto = IdProducto;
                    p.Producto = txtProductoDetalle.Text;
                    p.Cantidad = double.Parse(txtCantidad.Text);
                    p.SubTotal = p.Cantidad * PrecioProducto;
                    lp.Add(p);
                    LlenarDataTicket();
                    CalcularTotal();
                    LimpiarGrupo();

                }
                else
                    MessageBox.Show("Error, Cantidad no puede ir vacio");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar producto");
            }
        }
        public void LlenarDataTicket()
        {
            dvgVenta.DataSource = null;
            dvgVenta.DataSource = lp;
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
                lp.RemoveAt(posicion);
                LlenarDataTicket();
                CalcularTotal();
                btnQuitar.Enabled = false;
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            lp.Clear();
            LlenarDataTicket();
            CalcularTotal();
            LimpiarGrupo();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (lp.Count > 0)
                {
                    TicketVenta t = new TicketVenta();
                    t.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    t.FkIdUsuario = FrmInicioSesion.IdUser;
                    t.Total = total;
                    if (mpv.GuardarVenta(t, lp))
                    {
                        MessageBox.Show("Venta guardar correctamente");
                        lp.Clear();
                        LlenarDataTicket();
                        CalcularTotal();
                        LimpiarGrupo();
                        LlenarData("");
                    }
                    else
                        MessageBox.Show("Error al guardar la venta");
                }
                else
                    MessageBox.Show("Error ticket vacio");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCorteDeCaja_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = new DataTable();
                int id = FrmInicioSesion.IdUser;
                string Fecha = DateTime.Now.ToString("yyyy-MM-dd");
                dt = mpv.CorteDeCaja(id,Fecha);

                MessageBox.Show("Usuario: " + dt.Rows[0][0].ToString() + "\n\r" +
                    "Fecha: " + Fecha + "\n\r" +
                    "Total de venta realizado: " + dt.Rows[0][1].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar corte de caja");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lp.Count > 0)
            {
                if(cmbImpresoras.Text.Equals("Guardar Archivo"))
                {
                    contador++;
                    using (var fd = new FolderBrowserDialog())
                    {
                        if (fd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                        {
                            mpv.GenerarTicket(lp, fd.SelectedPath +"\\", total);
                        }
                    }
                }
                else
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.LoadFromFile(mpv.GenerarTicket(lp, "", total));
                    //Set the printer
                    pdf.PrintSettings.PrinterName = cmbImpresoras.Text;
                    pdf.Print();
                }
                
            }
            else
                MessageBox.Show("Error ticket vacio");
        }

        private void dvgVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = e.RowIndex;
                posicion = fila;
                
                btnQuitar.Enabled = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CalcularTotal()
        {
            total = 0.0;
            foreach (var item in lp)
            {
                total += item.SubTotal;
            }
            lblTotal.Text = "$" + total.ToString();
        }

    }
}
