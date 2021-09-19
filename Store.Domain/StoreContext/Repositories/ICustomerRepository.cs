using Store.Domain.StoreContext.Entities;

namespace Store.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
        bool CheckDocument(string documents);
        bool CheckEmail(string email);
        void Save(Customer customer);

    }
}