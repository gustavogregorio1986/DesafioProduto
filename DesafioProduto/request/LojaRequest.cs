namespace DesafioProduto.request
{
    public class LojaRequest
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public ItemEstoqueRequest ItemEstoqueRequest { get; set; }
    }
}
