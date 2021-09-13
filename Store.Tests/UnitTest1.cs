using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /* var c = new Customer(
                "Victor",
                "Sardellaro",
                "123",
                "Victor.Sardellaro@hotmail.com",
                "11 123456789",
                "Rua 123, Jd Bandeiras");

            var order = new Order(c); */

            var name = new Name("Victor", "Gonzalez");
            var document = new Document("12345678911");
            var email = new Email("victor.sardellaro@hotmail.com");
            var c = new Customer(name, document, email, "11944487845");
            var mouse = new Product("Mouse", "Rato", "image.png", 59.90m, 10);
            var teclado = new Product("Keyboard", "teclado", "image.png", 159.90m, 10);
            var impressora = new Product("Printer", "impressora", "image.png", 359.90m, 10);
            var cadeira = new Product("Chair", "Cadeira", "image.png", 559.90m, 10);

            var order = new Order(c);
            /* order.AddItem(new OrderItem(mouse, 5));
            order.AddItem(new OrderItem(teclado, 5));
            order.AddItem(new OrderItem(impressora, 5));
            order.AddItem(new OrderItem(cadeira, 5)); */

            // Realizei o pedido
            order.Place();

            // Verificar se o pedido é valido
            var valid = order.IsValid;

            // Simular o pagamento
            order.Pay();

            // Simular o envio
            order.Ship();

            // // Simular o cancelamento
            order.Cancel();

        }


    }
}
