using AccesoDatos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

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

        public DataSet ConsultarHorarios(string fecha)
        {
            var Conjunto = new DataSet();
            try
            {
                Conjunto = add.ConsultarHorarios(fecha);
                return Conjunto;
            }
            catch (Exception)
            {
                return Conjunto;
            }
        }

        public string ValidarEmpleado(TextBox tb)
        {
            string r = "";
            try
            {
                string[] separar = tb.Text.Split(' ');
                if (separar.Length < 3)
                {
                    r = "Se debe ingresar el nombre del empleado con sus apellidos separado por un espacio.";
                }
            }
            catch (Exception ex)
            {
                r = ex.Message;
            }
            return r;
        }
    }
}
