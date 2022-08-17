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
    public class LojaController : ControllerBase
    {
        private readonly LojaServico lojaServico;

        public LojaController()
        {
            lojaServico = new LojaServico();
        }

        [HttpPost]
        public JsonResult Salvar(Loja loja)
        {
            LojaRequest lojaRequest = new LojaRequest();
            loja = new Loja();
            loja.Id = lojaRequest.Id;
            loja.Nome = lojaRequest.Nome;
            loja.Endereco = lojaRequest.Endereco;
            lojaServico.InserirLoja(loja);
            return new JsonResult(lojaRequest);

        }

        [HttpPut]
        public JsonResult Atualizar(Loja loja)
        {
            LojaRequest lojaRequest = new LojaRequest();
            loja = new Loja();
            loja.Id = lojaRequest.Id;
            loja.Nome = lojaRequest.Nome;
            loja.Endereco = lojaRequest.Endereco;
            lojaServico.Atualizar(loja);
            return new JsonResult(lojaRequest);

        }

        [HttpGet]
        public List<Loja> ListarLoja()
        {
            List<Loja> listarLoja = new List<Loja>();

            foreach(var loja in listarLoja)
            {
                listarLoja.Add(loja);
                lojaServico.ListarLoja();
            }

            return listarLoja;
        }

        [HttpGet]
        public JsonResult Buscar(int id)
        {
            lojaServico.Buscar(id);

            return new JsonResult(id);
        }

        [HttpDelete]
        public JsonResult Deletar(int id)
        {
            lojaServico.Deletar(id);

            return new JsonResult(id);
        }
    }
}
