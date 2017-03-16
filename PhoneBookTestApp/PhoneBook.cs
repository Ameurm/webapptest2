using System;
using System.Linq;

namespace PhoneBookTestApp
{
    public class PhoneBook : IPhoneBook
    {

        public void addPerson(Person newPerson)
        {
           

            Person person = new Person();
            person.name= newPerson.name;
            person.phoneNumber = newPerson.phoneNumber;
            person.address = newPerson.address;
            
           

       

        }

        public Person findPerson(string firstName, string lastName)
        {
           Person person = new Person();
            var name = from p in person.name
                       select p;
            return person;
            
        }
    }
}