
using Store.Domain.StoreContext.Services;

namespace Store.Tests
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {

        }
    }
}