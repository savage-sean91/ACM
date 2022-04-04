using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer // make public class so it's accessible anywhere in this application
    {
        public Customer(): this(0) // this is called constructor chaining, use it anytime one constructor needs to call another; in this case default constructor calls parameterized constructor
        {

        }
        public Customer(int customerId) //constructor is special method that's executed when instance of class(object) is created
        {
            CustomerId = customerId; //this is an overloaded constructor
            AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; } //static means this prop belongs to the class itself and not any object created from the class
        //To access a static property, you wouldn't use the object name, you'd instead write Customer.InstanceCount for example
        private string _lastName; //this is referred to a backing field
        public string LastName
            
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FirstName { get; set; } // gets and sets automatically for you, and sets backing field behind the scenes
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
            return fullName;
            }
        }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; } // anyone can get the ID but only this class can set it
        public List<Address> AddressList { get; set; } // Establishes the composition and relationship between Customer and Address
        public int CustomerType { get; set; }

        // Methods 


        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }
        
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
      
    }
}

//contracts/interface, with public access modifier make promise to application with data and functionality (properties and methods) with any part of application that needs them.

//With composition, an object of one class is constructed with objects of another class, Address within Customer in this case