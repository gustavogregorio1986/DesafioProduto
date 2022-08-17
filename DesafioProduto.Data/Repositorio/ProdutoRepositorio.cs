using DesafioProduto.Data.Repositorio.Interface;
using DesafioProduto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProduto.Data.Repositorio
{
    public class ProdutoRepositorio : GenericRepositorio<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
