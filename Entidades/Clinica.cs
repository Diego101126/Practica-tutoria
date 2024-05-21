namespace practica_tutoria.Entidades
{
    public class Clinica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }



        //Relacion de una a muchos 
        public ICollection<Usuario> Usuarios { get; set; }

    }
}
