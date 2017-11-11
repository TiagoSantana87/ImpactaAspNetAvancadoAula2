using System;
using System.ComponentModel.DataAnnotations;

namespace Loja.Mvc.Validacoes
{
    public class IdadeMinimaAttribute : ValidationAttribute
    {
        private int _idadeMinima;
        private string _mensagemError;

        public IdadeMinimaAttribute(int idadeMinima)
        {
            _idadeMinima = idadeMinima;
            _mensagemError = $"Idade minima é de {_idadeMinima} anos";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dataNascimento = (DateTime)value;

            if (dataNascimento.AddYears(_idadeMinima) > DateTime.Now)
            {
                return new ValidationResult(_mensagemError);
            }
            return ValidationResult.Success;
        }
    }
}