using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Sean",
                LastName = "Savage",
                EmailAddress = "email@email.com"
            };
            string expected = "Savage, Sean";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Sean",
               // LastName = "Savage",
               // EmailAddress = "email@email.com"
            };
            string expected = "Sean";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "sean";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "kaela";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "tj";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            var customer = new Customer
            {
                LastName = "Savage",
                EmailAddress = "email@email.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // -- Arrange
            var customer = new Customer
            {
                EmailAddress = "email@email.com"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
