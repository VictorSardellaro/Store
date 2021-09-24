using System;
using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        // [Route("Clientes")] // Listar todos os clientes
        // [Route("Clientes/2587")] // Listar o Cliente 2587
        // [Route("Clientes/2587/pedidos")] // Pedidos do cliente 2587
        public object Get()
        {
            return new { version = "Version 0.0.1" };
        }

        [HttpGet]
        [Route("error")]
        public string Error()
        {
            throw new Exception("Algum erro ocorreu");
            return "erro";
        }
    }
}