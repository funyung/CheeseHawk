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

			
			

			Console.WriteLine("Hello, World!");

			handler.GetOldestContact();
		}
	}
}