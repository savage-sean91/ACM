using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository(); //establishes relationship between customer and address repository
        }
        private AddressRepository addressRepository { get; set; }
        public bool Save(Customer customer)
        {
            // code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId) //signature of method is comprised of its name and type of each of its formal parameters, signature does NOT include return type
                                                 //overloading is a terms that describes methods that have same name but different parameters
        {
            Customer customer = new Customer(customerId);

            //code that retrieves the defined customer

            //temporary hard-coded values to return
            //a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbit.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            // code that retrieves all of the customers
            return new List<Customer>();
        }
    }
}
