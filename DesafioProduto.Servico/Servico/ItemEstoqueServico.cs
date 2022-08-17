using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioProduto.Data.Repositorio;
using DesafioProduto.Dominio.Dominio;

namespace DesafioProduto.Servico.Servico
{
    public class ItemEstoqueServico
    {
        private readonly ItemEstoqueRepositorio itemEstoqueRepositorio;

        public ItemEstoqueServico()
        {
            itemEstoqueRepositorio = new ItemEstoqueRepositorio();
        }

        public void InserirItemEstoque(ItemEstoque itemEstoque)
        {
            itemEstoqueRepositorio.Adicionar(itemEstoque);
        }

        public void Atualizar(ItemEstoque itemEstoque)
        {
            itemEstoqueRepositorio.Atualizar(itemEstoque);
        }

        public void Deletar(int idItemEstoque)
        {
            itemEstoqueRepositorio.Deletar(idItemEstoque);
        }

        public ItemEstoque Buscar(int id)
        {
            return itemEstoqueRepositorio.Buscar(id, id);
        }

        public List<ItemEstoque> ListarItemEstoque()
        {
            return itemEstoqueRepositorio.ObterTodos();
        }
    }
}
