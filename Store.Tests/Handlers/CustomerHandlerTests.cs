using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.CustomerCommands.Inputs;
using Store.Domain.StoreContext.Handlers;

namespace Store.Tests
{
    [TestClass]
    public class CustomerHandlerCommandTests
    {

        [TestMethod]
        public void ShouldRegisterCustomerWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Victor";
            command.LastName = "Gonzalez";
            command.Document = "71375763032";
            command.Email = "victor.gonzalez@hotmail.com";
            command.Phone = "11944425784";

            Assert.AreEqual(true, command.Valid());

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());
        }

    }
}
