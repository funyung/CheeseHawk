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
							Console.Write("-------- ");
							Console.Write( handler.GetContactsTotalTab(c.Id).ToString() + "\n" );
						}
						Console.WriteLine("===================");
						Console.WriteLine("                   ");
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