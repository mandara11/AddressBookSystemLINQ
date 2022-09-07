namespace AddressBookSystemLinQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook System Using LinQ");

            // UC1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();

            // UC3
            //addressBookTable.GetAllContacts();

            // UC4
            //addressBookTable.EditExistingContact("Mandara", "M", "PhoneNumber", "9977665543");

            // UC5
            // addressBookTable.DeleteContact("Vishal", "Singh"); 

            // UC6
            // addressBookTable.RetrieveByCityOrState("Banglore", "Karnataka"); 

            // UC7
            // addressBookTable.CountByCityOrState("Banglore", "Karnataka");

            // UC8
            // addressBookTable.SortedContactsByNameForAgivenCity("Banglore");

            // UC9
            // addressBookTable.GetAllContacts();

            // UC10
            // addressBookTable.GetCountByAddressBookType();

            addressBookTable.RetrieveByUsingBookType("Friend");
        }
    }
}