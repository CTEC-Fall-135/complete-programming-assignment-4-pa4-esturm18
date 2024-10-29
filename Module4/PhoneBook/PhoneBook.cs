using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Emma Sturm
//Assignment4
//10/28/2024

namespace PhoneBook
{
    class PhoneBook
    {
        #region Fields
        private Entity[] entities;
        #endregion

        #region Constructor
        public PhoneBook()
        {
            entities = new Entity[10];
        }
        #endregion

        #region Methods
        //Add an entity method
        public void AddEntity(Entity entity)
        {
            for (int i = 0; i < entities.Length; i++)
            {
                if (entities[i] == null)
                {
                    entities[i] = entity;
                    return;
                }
            }
        }


        //Add a business
        public void AddBusinessEntity(int id, string name, Address address, string phoneNumber, string businessType, string businessName)
        {
            Business business = new Business(id, name, address, phoneNumber, businessType, businessName);
            AddEntity(business);

        }

        //Add a person method
        public void AddPersonEntity(int id, string name, Address address, string phoneNumber, string firstName, string lastName)
        {
            Person person = new Person(id, name, address, phoneNumber, firstName, lastName);
            AddEntity(person);  
        }

        //Print out all the items in the phone book
        public void PrintPhoneBook()
        {
            Console.WriteLine("Phonebook: ");
            foreach (Entity entity in entities)
            {
                if (entity != null)
                {
                    entity.PrintEntity();
                    Console.WriteLine();
                }
            }
        }
        #endregion

    }
}
