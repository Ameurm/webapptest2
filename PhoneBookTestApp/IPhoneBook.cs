namespace PhoneBookTestApp
{
    public interface IPhoneBook
    {
        Person findPerson(string name);
        void addPerson(Person newPerson);
    }
}