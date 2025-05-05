using System;
using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class VendedorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do vendedor não pode ter mais que 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        [StringLength(100, ErrorMessage = "O email não pode ter mais que 100 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório.")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "O telefone deve ter entre 10 e 15 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida.")]
        [AgeValidation(ErrorMessage = "O vendedor deve ser maior de idade.")]
        public DateTime DataNascimento { get; set; }

        public string Endereco { get; set; }

        [Required(ErrorMessage = "Data de contratação é obrigatória.")]
        [DataType(DataType.Date, ErrorMessage = "Data de contratação inválida.")]
        public DateTime DataContratacao { get; set; }

        [Required(ErrorMessage = "Comissão percentual é obrigatória.")]
        [Range(0, 100, ErrorMessage = "Comissão percentual deve estar entre 0 e 100.")]
        public decimal ComissaoPercentual { get; set; }

        [Required(ErrorMessage = "Meta mensal é obrigatória.")]
        [Range(0, double.MaxValue, ErrorMessage = "A meta mensal deve ser um valor positivo.")]
        public decimal MetaMensal { get; set; }

        public DateTime CriadoEm { get; set; }
    }

    public class AgeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dataNascimento)
            {
                var idade = DateTime.Now.Year - dataNascimento.Year;
                if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                    idade--;
                return idade >= 18;
            }
            return false;
        }
    }
}
