using System.ComponentModel.DataAnnotations;

namespace Biblioteca_10.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
