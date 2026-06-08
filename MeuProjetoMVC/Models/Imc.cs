using System.ComponentModel.DataAnnotations;

namespace MeuProjetoMVC.Models
{
    public class Imc
    {
        [Required]
        public double Peso { get; set; }

        [Required]
        public double Altura { get; set; }

        public double Resultado { get; set; }
    }
}