using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTestApp
{
   public class Program
    {
        //private PhoneBook phonebook = new PhoneBook();

        static void Main(string[] args)
        {
            try
            {
              
              // DatabaseUtil.initializeDatabase();
                /* TODO: create person objects and put them in the PhoneBook and database
                * John Smith, (248) 123-4567, 1234 Sand Hill Dr, Royal Oak, MI
                * Cynthia Smith, (824) 128-8758, 875 Main St, Ann Arbor, MI
                */

                // TODO: print the phone book out to System.out
                // TODO: find Cynthia Smith and print out just her entry
                // TODO: insert the new person objects into the database

                PhoneBook phonebook = new PhoneBook();

                Person person = new Person();
                person.name = "John Smith";
                person.phoneNumber = "(248) 123-4567";
                person.address = "1234 Sand Hill Dr, Royal Oak, MI";

            

                string name = person.name;
                phonebook.addPerson(person);
                phonebook.findPerson(name);
                Console.WriteLine("record added");
                // Console.ReadLine();
            }
            catch (Exception)
            {
               throw;
            }
            finally
            {
                DatabaseUtil.CleanUp();
            }
        }
    }
}
