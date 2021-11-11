namespace Entidades
{
    public class EntidadUsuarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Rol { get; set; }
        public string Estatus { get; set; }
        public string Contrasena { get; set; }

        public EntidadUsuarios(int id, string nombre, string apellidop, string apellidom, string usuario, string email, string telefono, string rol, string estatus, string contrasena )
        {
            ID = id;
            Nombre = nombre;
            ApellidoP = apellidop;
            ApellidoM = apellidom;
            Usuario = usuario;
            Email = email;
            Telefono = telefono;
            Rol = rol;
            Estatus = estatus;
            Contrasena = contrasena;
        }
    }
}
