namespace Entidades
{
    public class EntidadHorarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Fecha { get; set; }
        public string Turno { get; set; }

        public EntidadHorarios(int id, string nombre, string apellidop, string apellidom, string fecha, string turno)
        {
            ID = id;
            Nombre = nombre;
            ApellidoP = apellidop;
            ApellidoM = apellidom;
            Fecha = fecha;
            Turno = turno;
        }
    }
}
