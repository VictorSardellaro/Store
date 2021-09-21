using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.Queries;
using Store.Domain.StoreContext.Repositories;

namespace Store.Tests
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string documents)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public CustomerOrdersCountResult GetCustomerOrdersCount(string document)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Customer customer)
        {

        }
    }
}
