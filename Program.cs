namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Welcome to addressBook -------");
            Console.WriteLine("Please enter contact details");
            Contact contact = new();
            Console.WriteLine("Please enter first name of contact");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name of contact");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Please enter address of contact");
            contact.address = Console.ReadLine();
            Console.WriteLine("Please enter city of contact");
            contact.city = Console.ReadLine();
            Console.WriteLine("Please enter state of contact");
            contact.state = Console.ReadLine();
            Console.WriteLine("Please enter zipCode of contact");
            contact.zipcode = Console.ReadLine();
            Console.WriteLine("Please enter phoneNumber of contact");
            contact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter email of contact");
            contact.email = Console.ReadLine();
            Console.WriteLine(contact.ToString());
        }
    }
}