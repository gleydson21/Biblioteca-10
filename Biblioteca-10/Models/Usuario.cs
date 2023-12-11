using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Biblioteca_10.Models
{
    // Classe representando um usuário
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Livro> LivrosEmprestados { get; set; }
    }
}
