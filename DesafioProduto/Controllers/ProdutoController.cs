using DesafioProduto.Dominio.Dominio;
using DesafioProduto.request;
using DesafioProduto.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioProduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoServico produtoServico;

        public ProdutoController()
        {
            produtoServico = new ProdutoServico();
        }

        [HttpPost]
        public JsonResult Salvar(Produto produto)
        {
            ProdutoRequest produtoRequest = new ProdutoRequest();
            produto = new Produto();
            produto.Id = produtoRequest.Id;
            produto.Nome = produtoRequest.Nome;
            produto.Preco = produtoRequest.Preco;
            produtoServico.InserirProduto(produto);
            return new JsonResult(produtoRequest);

        }

        [HttpPut]
        public JsonResult Atualizar(Produto produto)
        {
            ProdutoRequest produtoRequest = new ProdutoRequest();
            produto = new Produto();
            produto.Id = produtoRequest.Id;
            produto.Nome = produtoRequest.Nome;
            produto.Preco = produtoRequest.Preco;
            produtoServico.InserirProduto(produto);
            return new JsonResult(produtoRequest);

        }

        [HttpGet]
        public List<Produto> ListarLoja()
        {
            List<Produto> listarProd = new List<Produto>();

            foreach (var prod in listarProd)
            {
                listarProd.Add(prod);
                produtoServico.ListarProduto();
            }

            return listarProd;
        }

        [HttpGet]
        public JsonResult Buscar(int id)
        {
            produtoServico.Buscar(id);

            return new JsonResult(id);
        }

        [HttpDelete]
        public JsonResult Deletar(int id)
        {
            produtoServico.Deletar(id);

            return new JsonResult(id);
        }
    }
}
