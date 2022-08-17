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
    public class ItemEstoqueController : ControllerBase
    {
        private readonly ItemEstoqueServico ItemEstoqueServico;

        public ItemEstoqueController()
        {
            ItemEstoqueServico = new ItemEstoqueServico();
        }

        [HttpPost]
        public JsonResult Salvar(ItemEstoque itemEstoque)
        {
            ItemEstoqueRequest itemEstoqueRequest = new ItemEstoqueRequest();
            itemEstoque = new ItemEstoque();
            itemEstoqueRequest.Id = itemEstoque.Id;
            itemEstoqueRequest.Qtde = itemEstoqueRequest.Qtde;
            ItemEstoqueServico.InserirItemEstoque(itemEstoque);
            return new JsonResult(itemEstoqueRequest);

        }

        [HttpPut]
        public JsonResult Atualizar(ItemEstoque itemEstoque)
        {
            ItemEstoqueRequest itemEstoqueRequest = new ItemEstoqueRequest();
            itemEstoque = new ItemEstoque();
            itemEstoqueRequest.Id = itemEstoque.Id;
            itemEstoqueRequest.Qtde = itemEstoqueRequest.Qtde;
            ItemEstoqueServico.InserirItemEstoque(itemEstoque);
            return new JsonResult(itemEstoqueRequest);

        }

        [HttpGet]
        public List<ItemEstoque> ListarItemEstoque()
        {
            List<ItemEstoque> listarItemEstoque = new List<ItemEstoque>();

            foreach (var itemEstoque in listarItemEstoque)
            {
                listarItemEstoque.Add(itemEstoque);
                ItemEstoqueServico.ListarItemEstoque();
            }

            return listarItemEstoque;
        }

        [HttpGet]
        public JsonResult Buscar(int id)
        {
            ItemEstoqueServico.Buscar(id);

            return new JsonResult(id);
        }

        [HttpDelete]
        public JsonResult Deletar(int id)
        {
            ItemEstoqueServico.Deletar(id);

            return new JsonResult(id);
        }
    }
}
