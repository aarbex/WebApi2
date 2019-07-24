using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class ClienteController : ApiController
    {
        private List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente(){ Id = 1, Nome = "André Arbex", Telefone = "(11) 97466-4075"},
            new Cliente(){ Id = 2, Nome = "Victor Arbex", Telefone = "(11) 97466-4075"},
            new Cliente(){ Id = 3, Nome = "Marcia Arbex", Telefone = "(11) 99768-2011"},
            new Cliente(){ Id = 4, Nome = "Arthur Arbex", Telefone = "(11) 97466-4075"}
    };

        public IEnumerable<Cliente> Get()
        {
            return clientes.ToList();
        }

        public Cliente Get(int id)
        {
            return clientes.FirstOrDefault(x => x.Id == id);
        }

    }
}
