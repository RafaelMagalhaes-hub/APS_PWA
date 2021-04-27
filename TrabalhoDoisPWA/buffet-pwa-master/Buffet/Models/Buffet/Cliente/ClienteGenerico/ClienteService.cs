using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        private readonly DatabaseContext _databaseContext;

        public ClienteService(
            DatabaseContext databaseContext
        )
        {
            _databaseContext = databaseContext;
        }
 
        public void ObterClientes()
        {
            // OBTER UM ÚNICO OBJETO
            /*
            var primeiroCliente = _databaseContext.Clientes.First();
            var primeiroClienteOuNulo = _databaseContext.Clientes.FirstOrDefault();
            var clienteEspecifico1 = _databaseContext
                .Clientes.Single(c => c.Id.ToString()
                    .Equals("08d8f887-cd09-421d-8ee1-a0f9f0d36e57") );
            var clienteEspecifico2 = _databaseContext
                .Clientes.Single(c => c.Nome.Contains("Jo") );
            var clienteEspecifico3 = _databaseContext
                .Clientes.Find("08d8f887-cd09-421d-8ee1-a0f9f0d36e57");
            
            if (clienteEspecifico != null) {
                Console.WriteLine(clienteEspecifico.Id);
                Console.Write(" :: " + clienteEspecifico.Nome);
                Console.Write(" :: " + clienteEspecifico.Email);
            }
            */
            
            // OBTER MÚLTIPLOS OBJETOS
            //var clientes = _databaseContext.Clientes.ToList();
            /*
            var clientes = _databaseContext.Clientes
                .Where(
                    c => c.Nome.StartsWith("Jo") &&
                                    c.Nome.EndsWith("e")
                ).ToList();
            */
            
            // ORDENAÇÃO
            /*
            var clientes = _databaseContext.Clientes
                .OrderBy(c => c.Nome).ToList();
            */
            /*
            foreach (var cliente in clientes) {
                Console.WriteLine("----");
                Console.WriteLine(cliente.Id);
                Console.Write(" :: " + cliente.Nome);
                Console.Write(" :: " + cliente.Email);
            }
            */         
            
        }
    }
}