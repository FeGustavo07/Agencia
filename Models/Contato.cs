using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Models
{
    [Table("Contato")]
    public class Contato
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        [Required]
        public string Mensagem { get; set; }

    }
}
