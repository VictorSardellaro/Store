using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.Entities;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Victor",
                "Sardellaro",
                "123",
                "Victor.Sardellaro@hotmail.com",
                "11 123456789",
                "Rua 123, Jd Bandeiras");

            var order = new Order(c);



        }


    }
}
