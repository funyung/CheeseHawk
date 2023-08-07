using Microsoft.EntityFrameworkCore.Internal;
using CheeseHawk.Services;
using CheeseHawk.Models;

namespace CheeseHawk
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CheeseHawkContext context = new CheeseHawkContext();

			DatabaseInitializer init = new DatabaseInitializer(context);
			init.InitializeDB();

			DatabaseHandler handler = new DatabaseHandler(context);
			
			Console.WriteLine("Hello, Welcome to my SQLite database application!\n");

			bool run = true;

			while (run)
			{
				Console.WriteLine("Use the commands below to interact.");
				Console.WriteLine("1. Report of your contacts. *");
				Console.WriteLine("2. Create a new contact.");
				Console.WriteLine("3. Create a payment request. *");
				Console.WriteLine("4. Get oldest contact.");
				string input = Console.ReadLine();

				switch (input)
				{
					case "1":
						List<UserContact> contacts = handler.GetAllContacts();
						foreach(var c in contacts)
						{
							Console.Write(c.UserName + " ");
							Console.Write("-------- ");
							Console.Write(c.PhoneNumber + " ");
							Console.Write("-------- \n");
							//Console.Write( handler.GetContactsTotalTab(c.ContactId).ToString() + "\n" );
						}
						Console.WriteLine("===================");
						Console.WriteLine("                   ");
						break;
					case "2":
						Console.WriteLine("What is the username?");
						string newName = Console.ReadLine();

						Console.WriteLine("What is their phone number?");
						string newNumber = Console.ReadLine();

						handler.AddContact(newName, newNumber);
						break;
					case "3":
						break;
					case "4":
						handler.GetOldestContact();
						break;
					default:
						Console.WriteLine("Sorry, not a valid input.");
						break;
				}
			}
			
			handler.GetOldestContact();
			Console.WriteLine("Goodbye!\n");
		}
	}
}