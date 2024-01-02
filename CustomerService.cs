using KarigarBotique.Model;
namespace KarigarBotique.Services.CustomerServices
{
    public class CustomerService : ICustomerServices
    {
        private static List<Customer> customers = new List<Customer> {

            new Customer {
                    Id = 1,
                    Cust_Name = "Ali Raza",
                    Cust_Email= "ali.razakhanskt@gmail.com",
                    Cust_Address = "Narang Mandi",
                    Cust_Phone = "03095652004"
                },

            new Customer {
                    Id = 2,
                    Cust_Name = "Malik Aftab",
                    Cust_Email= "malikskt@gmail.com",
                    Cust_Address = "Sialkot",
                    Cust_Phone = "03095652005"
                },

            new Customer {
                    Id = 3,
                    Cust_Name = "Mursleen Butt",
                    Cust_Email= "mursleen@gmail.com",
                    Cust_Address = "Phool Nagar",
                    Cust_Phone = "03095652006"
                },

            new Customer {
                    Id = 4,
                    Cust_Name = "Abdul Rehman",
                    Cust_Email= "gujjerskt@gmail.com",
                    Cust_Address = "Aimnabad",
                    Cust_Phone = "03095652007"
                }
            };
        

        public List<Customer> AddCustomer(Customer customer)
        {
            customers.Add(customer);
            return customers;
        }

        public List<Customer>? DeleteCustomer(int id)
        {
            var cust = customers.Find(x => x.Id == id);
            if (cust == null)
            {
                return null;
            }
            customers.Remove(cust);
            return customers;

        }

        public List<Customer> GetAllCustomer()
        {
         return customers;
        }

        public Customer? GetSingleCustomer(int id)
        {
            var result = customers.Find(x => x.Id == id);
            if (result  == null)
                return null;

            return result;
        }

        public List<Customer>? UpdateCustomer(int id, Customer req)
        {
            var cust = customers.Find(x => x.Id == id);
            if (cust == null)
            {
                return null;
            }
            cust.Cust_Address = req.Cust_Address;
            cust.Cust_Phone = req.Cust_Phone;
            cust.Cust_Email = req.Cust_Email;
            cust.Cust_Name = req.Cust_Name;
            return customers;
        }
    }
}
