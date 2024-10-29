using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public abstract class Entity
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }

        public Address Address { get; set; }    
        public string PhoneNumber { get; set; }
        #endregion

        #region Constructor
        protected Entity(int id, string name, Address address, string phoneNumber)
        { 
            ID = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        #endregion

        #region Methods
        public abstract void PrintEntity();
        #endregion

    }

    public class Business: Entity
    {
        #region Properties
        public string BusinessType { get; set; }
        public string BusinessName { get; set; }
        #endregion

        #region Constructor
        public Business(int id, string name, Address address, string phoneNumber, string businessType, string businessName)
            : base(id, name, address, phoneNumber)
        {
            BusinessType = businessType;
            BusinessName = businessName;
        }
        #endregion

        #region Methods
        public override void PrintEntity()
        {
            Console.WriteLine($"Business Type: {BusinessType}");
            PrintAddress();
            Console.WriteLine($"Phone: {PhoneNumber}");
        }

        public void PrintAddress()
        {
            Console.WriteLine($"Business Name: {BusinessName}");
            Address.PrintAddress();
        }
        #endregion

    }

    public class Person : Entity
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Constructor
        public Person(int id, string name, Address address, string phoneNumber, string firstName, string lastName)
            : base(id, name, address, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName; 
        }
        #endregion

        #region Methods
        public override void PrintEntity()
        {
            PrintAddress();
            Console.WriteLine($"Phone: {PhoneNumber}");
        }

        public void PrintAddress()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Address.PrintAddress();
        }
        #endregion
    }
}
