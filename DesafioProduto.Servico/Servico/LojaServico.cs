using DesafioProduto.Data.Repositorio;
using DesafioProduto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProduto.Servico.Servico
{
    public class LojaServico
    {
        private readonly LojaRepositorio lojaRepositorio;

        public LojaServico()
        {
            lojaRepositorio = new LojaRepositorio();
        }

        public void InserirLoja(Loja loja)
        {
            lojaRepositorio.Adicionar(loja);
        }

        public List<Loja> ListarLoja()
        {
            return lojaRepositorio.ObterTodos();
        }

        public void Atualizar(Loja loja)
        {
            lojaRepositorio.Atualizar(loja);
        }

        public void Deletar(int idLoja)
        {
            lojaRepositorio.Deletar(idLoja);
        }

        public Loja Buscar(int id)
        {
            return lojaRepositorio.Buscar(id, id);
        }
    }
}
