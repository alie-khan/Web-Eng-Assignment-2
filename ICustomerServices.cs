namespace KarigarBotique.Services.CustomerServices
{
    public interface ICustomerServices
    {
        List<Customer> GetAllCustomer();
        Customer? GetSingleCustomer(int id);
        List<Customer> AddCustomer(Customer custumor);
        List<Customer>? UpdateCustomer(int id, Customer req);
        List<Customer>? DeleteCustomer(int id);
    }
}
