using CustomerService.Models;

namespace CustomerService.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer Add(Customer newItem);
        Customer GetById(int id);
        //void Remove(int id);
    }
}
