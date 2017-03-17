using System;
using System.Linq;
using System.Data.SQLite;

namespace PhoneBookTestApp
{
    public class PhoneBook : IPhoneBook
    {

        public void addPerson(Person newPerson)
        {
            string connectionString = @"Data Source = C:/Database/MyDatabase.db; Version = 3; New = True; Compress = True;";
            Person person = new Person();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "INSERT INTO PHONEBOOK (NAME, PHONENUMBER, ADDRESS) VALUES(@NAME,@PHONENUMBER,@ADDRESS)";
                cmd.Connection = con;
                cmd.Parameters.Add(new SQLiteParameter("@NAME", newPerson.name));
                cmd.Parameters.Add(new SQLiteParameter("@PHONENUMBER", newPerson.phoneNumber));
                cmd.Parameters.Add(new SQLiteParameter("@ADDRESS", newPerson.address));

                con.Open();
                cmd.ExecuteNonQuery();
            }
                
            //person.name = newPerson.name;
            //person.phoneNumber = newPerson.phoneNumber;
            //person.address = newPerson.address;
        }

        public Person findPerson(string name)
        {
            Person person = new Person();
            // var sname = from p in person.name
            //            select p;
            // return person;
            string connectionString = @"Data Source = C:/Database/MyDatabase.db; Version = 3; New = True; Compress = True;";
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "SELECT * FROM PHONEBOOK WHERE name = @NAME";
                cmd.Connection = con;
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    string phoneNumber = reader.GetString(1);
                    string address = reader.GetString(2);

                }
                return person;
            }


        }
    }
}