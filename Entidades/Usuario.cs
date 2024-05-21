using System.Reflection.Metadata;

namespace practica_tutoria.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public string Contraseña { get; set; }
        public Clinica Clinica { get; set; }
        public ExpedienteMedico ExpedienteMedico { get; set; }

    }
}
