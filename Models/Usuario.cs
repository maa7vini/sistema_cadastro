using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPratico1.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Display(Name = "userId")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Usuários")]
        [Column("nome")]
        public string Nome { get; set; }
    }
}
