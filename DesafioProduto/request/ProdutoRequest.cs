using System.ComponentModel.DataAnnotations;

namespace DesafioProduto.request
{
    public class ProdutoRequest
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public decimal Preco { get; set; }
    }
}
