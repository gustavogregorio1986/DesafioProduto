using DesafioProduto.Data.Repositorio.Interface;
using DesafioProduto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProduto.Data.Repositorio
{
    public class LojaRepositorio : GenericRepositorio<Loja>, ILojaRepositorio
    {
        public IEnumerable<Loja> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
