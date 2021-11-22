using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Manejadores
{
    public class ManejadorPuntoDeVenta
    {
        int x = 1;
        public DataSet ListasProductos(string Nombre)
        {
            var AD = new AccesoADatosIvan();
            var Conjunto = new DataSet();
            Conjunto = AD.ListarProductos(Nombre);
            return Conjunto;

        }
        public bool GuardarVenta(TicketVenta t, List<ListaProductos> l)
        {
            var AD = new AccesoADatosIvan();
            ListaProductos lp = new ListaProductos();
            lp.IdProducto = 0;
            lp.Producto = "";
            lp.Cantidad = 0.0;
            lp.SubTotal = 0.0;
            bool resultado = true;
            if (AD.GuardarVenta(t, lp, 1))
            {
                for (int i = 0; i < l.Count; i++)
                {
                    lp.IdProducto = l[i].IdProducto;
                    lp.Producto = l[i].Producto;
                    lp.Cantidad = l[i].Cantidad;
                    lp.SubTotal = l[i].SubTotal;
                    if(AD.GuardarVenta(t,lp,2))
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                    }
                }
                return resultado;
            }
            else
                return false;
        }
        public DataTable CorteDeCaja(int IdUser, string Fecha)
        {
            var AD = new AccesoADatosIvan();
            var dt = new DataTable();
            dt = AD.CorteDeCaja(IdUser, Fecha);
            return dt;
        }
        public string GenerarTicket(List<ListaProductos> l,string ruta,double total)
        {
            string Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Document doc = new Document(PageSize.B7);

            PdfWriter writer;


            if (ruta.Equals(""))
            {
                writer = PdfWriter.GetInstance(doc,
                                     new FileStream("Ticket.pdf", FileMode.Create));
            }
            else
            {
                writer = PdfWriter.GetInstance(doc,
                                        new FileStream(ruta + "Ticket " + Fecha + " " + x.ToString() + ".pdf", FileMode.Create));
            }

            
          
            doc.AddTitle("Ticket Venta");
            doc.AddCreator("Abarrotes Sandra");

            // Abrimos el archivo
            doc.Open();
            // Se crea el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            

            // Se escribe el encabezamiento en el documento
            doc.Add(new Paragraph("Ticket de venta",_standardFont));
            doc.Add(new Paragraph("Abarrotes Sandra",_standardFont));
            doc.Add(Chunk.NEWLINE);

            // Se crean las tablas (en este caso 3)
            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 90;

            // Se configura el título de las columnas de la tabla
            PdfPCell clCodigo = new PdfPCell(new Phrase("Codigo", _standardFont));
            clCodigo.BorderWidth = 0;
            clCodigo.BorderWidthBottom = 0.75f;

            PdfPCell clProducto = new PdfPCell(new Phrase("Producto", _standardFont));
            clProducto.BorderWidth = 0;
            clProducto.BorderWidthBottom = 0.75f;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clSubTotal = new PdfPCell(new Phrase("Subtotal", _standardFont));
            clSubTotal.BorderWidth = 0;
            clSubTotal.BorderWidthBottom = 0.75f;

            // se añade las celdas a la tabla
            tblPrueba.AddCell(clCodigo);
            tblPrueba.AddCell(clProducto);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clSubTotal);

            foreach (var item in l)
            {
                clCodigo = new PdfPCell(new Phrase(item.IdProducto.ToString(), _standardFont));
                clCodigo.BorderWidth = 0;

                clProducto = new PdfPCell(new Phrase(item.Producto, _standardFont));
                clProducto.BorderWidth = 0;

                clCantidad = new PdfPCell(new Phrase(item.Cantidad.ToString(), _standardFont));
                clCantidad.BorderWidth = 0;

                clSubTotal = new PdfPCell(new Phrase(item.SubTotal.ToString(), _standardFont));
                clSubTotal.BorderWidth = 0;

                tblPrueba.AddCell(clCodigo);
                tblPrueba.AddCell(clProducto);
                tblPrueba.AddCell(clCantidad);
                tblPrueba.AddCell(clSubTotal);
            }

            clCodigo = new PdfPCell(new Phrase("", _standardFont));
            clCodigo.BorderWidth = 0;

            clProducto = new PdfPCell(new Phrase("", _standardFont));
            clProducto.BorderWidth = 0;

            clCantidad = new PdfPCell(new Phrase("Su total es: $", _standardFont));
            clCantidad.BorderWidth = 0;

            clSubTotal = new PdfPCell(new Phrase(total.ToString(), _standardFont));
            clSubTotal.BorderWidth = 0;

            tblPrueba.AddCell(clCodigo);
            tblPrueba.AddCell(clProducto);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clSubTotal);


            // Finalmente, se añade la tabla al documento PDF y se cierra el documento
            doc.Add(tblPrueba);
           

            doc.Close();
            writer.Close();
            string resultado = "Ticket " + Fecha + " " + x.ToString() + ".pdf";
            x++;
            return resultado;
            
            //string pdfPath = Path.Combine(Application.StartupPath, ruta + @"\Ticket " + Fecha + " " + x.ToString() + ".pdf");
            // Process.Start(pdfPath);

        }
    }
}
