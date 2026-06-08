using System.ComponentModel.DataAnnotations;

namespace MeuProjetoMVC.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        [StringLength(50)]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Data de nascimento obrigatória")]
        public DateTime DataNascimento { get; set; }
    }
}