using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.API.Domain.Entities
{
    [Table("tb_vendedores")]
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }

        [Required]
        public DateTime DataContratacao { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal ComissaoPercentual { get; set; }

        [Required]
        public decimal MetaMensal { get; set; }

        [Required]
        public DateTime CriadoEm { get; set; }
    }
}
