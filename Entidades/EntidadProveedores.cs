namespace Entidades
{
    public class EntidadProveedores
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Telefono { get; set; }
        public string RFC { get; set; }
        public string RazonSocial { get; set; }
        public string Estatus { get; set; }

        public EntidadProveedores(int id, string nombre, string apellidop, string apellidom, string telefono, string rfc, string razonsocial, string estatus)
        {
            ID = id;
            Nombre = nombre;
            ApellidoP = apellidop;
            ApellidoM = apellidom;
            Telefono = telefono;
            RFC = rfc;
            RazonSocial = razonsocial;
            Estatus = estatus;
        }
    }
}
