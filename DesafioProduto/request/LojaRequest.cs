using System.ComponentModel.DataAnnotations;

namespace DesafioProduto.request
{
    public class LojaRequest
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Endereco { get; set; }

        public ItemEstoqueRequest ItemEstoqueRequest { get; set; }
    }
}
