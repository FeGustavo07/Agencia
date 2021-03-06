using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Agencia.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Email { get; set;}

        [Required]
        public string Senha { get; set;}

        [Required]
        [StringLength(11)]
        public string CPF { get; set;}

        [Required]
        public int Telefone { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public int Numero { get; set; }


        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

    }
}
