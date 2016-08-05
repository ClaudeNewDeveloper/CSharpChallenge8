using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest8
{
    class Program
    {
        static Dictionary<string, int> phoneBook = new Dictionary<string, int>();

        static void Main(string[] args)
        {

            char[] delimiterChars = {' '};
            Console.WriteLine("Please, enter the number of contacts in the phone book");
      
            string numberOfContacts = Console.ReadLine();
            int numberOfContactsInPhoneBook = Convert.ToInt32(numberOfContacts);

            for (int i = 0; i < numberOfContactsInPhoneBook; i++)
            {
                string userTextInput = Console.ReadLine();
                string[] nameAndPhoneNumber = userTextInput.Split(delimiterChars);
                string name = nameAndPhoneNumber[0];
                string phone = nameAndPhoneNumber[1];
                int phoneNumber = Convert.ToInt32(phone);

                phoneBook.Add(name, phoneNumber);

            }

            string nameToSearch;

            do
            {
                nameToSearch = Console.ReadLine();

                if (nameToSearch != null)
                {
                    if (phoneBook.ContainsKey(nameToSearch))
                    {
                        int phoneNumberassociated = phoneBook[nameToSearch];
                        Console.WriteLine(nameToSearch + " = " + phoneNumberassociated);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }

            }
            while (nameToSearch != null);

            Console.ReadKey();
        }

    }
}
