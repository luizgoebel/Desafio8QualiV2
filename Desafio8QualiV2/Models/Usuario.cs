using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio8QualiV2.Models
{
    public class Usuario : BaseModel
    {
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }
        public string? Empresa { get; set; }
        public string? Email { get; set; }
        public string? TelefonePessoal { get; set; }
        public string? TelefoneComercial { get; set; }
    }
}
