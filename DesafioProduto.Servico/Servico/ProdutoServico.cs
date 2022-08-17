using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProduto.Dominio.Dominio;

namespace DesafioProduto.Servico.Servico
{
    public class ProdutoServico
    {
        private readonly ProdutoServico produtoServico;

        public ProdutoServico()
        {
            produtoServico = new ProdutoServico();
        }

        public void InserirProduto(Produto produto)
        {
            produtoServico.InserirProduto(produto); 
        }

        public void Atualizar(Produto produto)
        {
            produtoServico.Atualizar(produto);
        }

        public void Deletar(int idProduto)
        {
            produtoServico.Deletar(idProduto);
        }

        public List<Produto> ListarProduto()
        {
            return produtoServico.ListarProduto();
        }
        public Produto Buscar(int id)
        {
            return produtoServico.Buscar(id);
        }
    }
}
