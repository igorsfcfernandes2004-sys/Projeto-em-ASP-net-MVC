using System.ComponentModel.DataAnnotations;

namespace MeuProjetoMVC.Models
{
    public class Endereco
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cep { get; set; }

        public string Numero { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }
    }
}