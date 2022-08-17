using System.ComponentModel.DataAnnotations;

namespace DesafioProduto.request
{
    public class ItemEstoqueRequest
    {
        public int Id { get; set; }

        [Required]
        public int Qtde { get; set; }

        public ProdutoRequest ProdutoRequest { get; set; }
    }
}
