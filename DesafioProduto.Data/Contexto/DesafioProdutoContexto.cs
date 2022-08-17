using DesafioProduto.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProduto.Data.Contexto
{
    public class DesafioProdutoContexto : DbContext
    {
        public DesafioProdutoContexto()
        {

        }

        public DesafioProdutoContexto(DbContextOptions option)
            :base(option)
        {

        }

        public static DbContextOptions<DbContext> GetInMemoryDbContextOptions(string dbName = "proddesafio_db")
        {
            var options = new DbContextOptionsBuilder<DbContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            return options;
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ItemEstoque> ItemEstoques { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        
    }
}
