
//Name: Emma Sturm
//Date: 10/8/2024
//Assignment4

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a business and a person
            Address businessAddress = new Address("1300 Conch St", "Bikini Bottom", "MI", "41010");
            Address personAddress = new Address("124 Conch St", "Bikini Bottom", "MI", "41008");

            //Create phonebook
            PhoneBook phoneBook = new PhoneBook();

            //Add entities to phonebook
            phoneBook.AddBusinessEntity(1, "BusinessOne", businessAddress, "505-111-2222", "Restuarant", "Krusty Krab");
            phoneBook.AddPersonEntity(2, "personOne", personAddress, "111-222-3333", "SpongeBob", "Squarepants"); 
            phoneBook.PrintPhoneBook();
        }
    }
}
