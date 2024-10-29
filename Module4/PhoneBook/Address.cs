using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Emma Sturm
//Date: 10/28/2024
//Assignment4

namespace PhoneBook

{
 //Address class
    public class Address
    {
        #region Properties
        public string StreetAddress {  get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        #endregion

        #region Constructor
        public Address(string streetAddress, string city, string state, string zipCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
        #endregion

        #region Methods
        public void PrintAddress()
        {
            Console.WriteLine($"{StreetAddress}");
            Console.WriteLine($"{City} {State} {ZipCode}");
        }
        #endregion
    }
}
