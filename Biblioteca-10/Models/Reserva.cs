namespace Biblioteca_10.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataReserva { get; set; }
        public Livro? Livro { get; set; }
        public Usuario? Usuario { get; set; }
    }
}