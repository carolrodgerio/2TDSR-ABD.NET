using System;
using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class FornecedorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do fornecedor não pode ter mais que 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CNPJ é obrigatório.")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "CNPJ deve ter exatamente 18 caracteres.")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "Formato de CNPJ inválido. O formato correto é: XX.XXX.XXX/XXXX-XX.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório.")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "O telefone deve ter entre 10 e 15 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        [StringLength(100, ErrorMessage = "O email não pode ter mais que 100 caracteres.")]
        public string Email { get; set; }

        public string Endereco { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
