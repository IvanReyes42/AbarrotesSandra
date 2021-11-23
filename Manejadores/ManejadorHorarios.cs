using AccesoDatos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;

namespace Manejadores
{
    public class ManejadorHorarios
    {
        AccesoDatosDaniel add = new AccesoDatosDaniel();

        public string GuardarHorarios(EntidadHorarios eh)
        {
            string mensaje;
            if (add.GuardarHorarios(eh))
            {
                mensaje = "Datos registrados correctamente.";
            }
            else
            {
                mensaje = "Error al registrar los datos.";
            }
            return mensaje;
        }

        public string ModificarHorarios(EntidadHorarios eh)
        {
            string mensaje;
            if (add.ModificarHorarios(eh))
            {
                mensaje = "Datos modificados correctamente.";
            }
            else
            {
                mensaje = "Error al modificar los datos.";
            }
            return mensaje;
        }

        public string EliminarHorarios(EntidadHorarios eh)
        {
            return add.EliminarHorarios(eh);
        }

        public DataSet ConsultarHorarios(string fecha,string fechafin)
        {
            var Conjunto = new DataSet();
            try
            {
                Conjunto = add.ConsultarHorarios(fecha,fechafin);
                return Conjunto;
            }
            catch (Exception)
            {
                return Conjunto;
            }
        }

        //public string ValidarEmpleado(TextBox tb)
        //{
        //    string r = "";
        //    try
        //    {
        //        string[] separar = tb.Text.Split(' ');
        //        if (separar.Length < 3)
        //        {
        //            r = "Se debe ingresar el nombre del empleado con sus apellidos separado por un espacio.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        r = ex.Message;
        //    }
        //    return r;
        //}

        public DataSet LlenarComboEmpleados()
        {
            var Conjunto = new DataSet();
            Conjunto = add.ListarEmpleados();
            return Conjunto;
        }

        public string ReporteHorarios(List<EntidadHorarios> h, string fechain, string fechafin)
        {
            Document doc = new Document(PageSize.LETTER); ;

            PdfWriter writer = PdfWriter.GetInstance(doc,
                                     new FileStream("Reporte Horario de "+fechain+" a "+fechafin+".pdf", FileMode.Create));


            doc.AddTitle("Reporte Horarios");
            doc.AddCreator("Abarrotes Sandra");

            // Abrimos el archivo
            doc.Open();
            // Se crea el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            Font _Titulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            // Se escribe el encabezamiento en el documento
            doc.Add(new Paragraph("Reporte Horarios", _Titulo));
            doc.Add(new Paragraph("De: "+fechain+" A: "+fechafin, _standardFont));
            doc.Add(Chunk.NEWLINE);

            // Se crean las tablas (en este caso 3)
            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 90;

            // Se configura el título de las columnas de la tabla
            PdfPCell clCodigo = new PdfPCell(new Phrase("Codigo", _standardFont));
            clCodigo.BorderWidth = 0;
            clCodigo.BorderWidthBottom = 0.75f;

            PdfPCell clProducto = new PdfPCell(new Phrase("Empleado", _standardFont));
            clProducto.BorderWidth = 0;
            clProducto.BorderWidthBottom = 0.75f;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Fecha", _standardFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clSubTotal = new PdfPCell(new Phrase("Turno", _standardFont));
            clSubTotal.BorderWidth = 0;
            clSubTotal.BorderWidthBottom = 0.75f;

            // se añade las celdas a la tabla
            tblPrueba.AddCell(clCodigo);
            tblPrueba.AddCell(clProducto);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clSubTotal);

            foreach (var item in h)
            {
                clCodigo = new PdfPCell(new Phrase(item.ID.ToString(), _standardFont));
                clCodigo.BorderWidth = 0;

                clProducto = new PdfPCell(new Phrase(item.Nombre+" "+item.ApellidoP+" "+item.ApellidoM, _standardFont));
                clProducto.BorderWidth = 0;

                clCantidad = new PdfPCell(new Phrase(item.Fecha, _standardFont));
                clCantidad.BorderWidth = 0;

                clSubTotal = new PdfPCell(new Phrase(item.Turno.ToString(), _standardFont));
                clSubTotal.BorderWidth = 0;

                tblPrueba.AddCell(clCodigo);
                tblPrueba.AddCell(clProducto);
                tblPrueba.AddCell(clCantidad);
                tblPrueba.AddCell(clSubTotal);
            }

            // Finalmente, se añade la tabla al documento PDF y se cierra el documento
            doc.Add(tblPrueba);


            doc.Close();
            writer.Close();
            string resultado = "Reporte Horario de " + fechain + " a " + fechafin + ".pdf";


            return resultado;
        }


    }
}
