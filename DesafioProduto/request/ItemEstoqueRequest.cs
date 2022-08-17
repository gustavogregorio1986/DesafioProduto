namespace DesafioProduto.request
{
    public class ItemEstoqueRequest
    {
        public int Id { get; set; }

        public int Qtde { get; set; }

        public ProdutoRequest ProdutoRequest { get; set; }
    }
}
