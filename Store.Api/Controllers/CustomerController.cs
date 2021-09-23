using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Store.Domain.StoreContext.CustomerCommands.Inputs;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Api.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("customers")]
        public List<Customer> Get()
        {
            var name = new Name("Victor", "Gonzalez");
            var document = new Document("46718115533");
            var email = new Email("hello@hotmail.com");
            var customer = new Customer(name, document, email, "551999876542");
            var customers = new List<Customer>();
            customers.Add(customer);
            return customers;
        }

        [HttpGet]
        [Route("customers/{id}")]
        public Customer GetById(Guid id)
        {
            var name = new Name("Victor", "Gonzalez");
            var document = new Document("46718115533");
            var email = new Email("hello@hotmail.com");
            var customer = new Customer(name, document, email, "551999876542");
            var customers = new List<Customer>();
            customers.Add(customer);
            return customer;
        }

        [HttpGet]
        [Route("customers/{id}/orders")]
        public List<Order> GetOrders(Guid id)
        {
            var name = new Name("Victor", "Gonzalez");
            var document = new Document("46718115533");
            var email = new Email("hello@hotmail.com");
            var customer = new Customer(name, document, email, "551999876542");
            var order = new Order(customer);
            var mouse = new Product("Mouse Gamer", "Mouse Gamer", "mouse.jpg", 100M, 10);
            var keyboard = new Product("Teclado Gamer", "Teclado Gamer", "Teclado.jpg", 100M, 10);

            order.AddItem(mouse, 15);
            order.AddItem(keyboard, 15);

            var orders = new List<Order>();
            orders.Add(order);

            return orders;

        }

        [HttpPost]
        [Route("customers")]
        public Customer Post([FromBody] CreateCustomerCommand command)
        {
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);
            var customer = new Customer(name, document, email, command.Phone);
            return customer;
        }

        [HttpPut]
        [Route("customers/{id}")]
        public Customer Put([FromBody] CreateCustomerCommand command)
        {
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);
            var customer = new Customer(name, document, email, command.Phone);
            return customer;
        }

        [HttpDelete]
        [Route("customers/{id}")]
        public object Delete()
        {
            return new { message = "Cliente removido com sucesso" };
        }
    }
}