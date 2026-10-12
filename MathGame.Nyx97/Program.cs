namespace mathGame;
class Program 
{
	public static void Main()
	{
		var active = true;
		while(active)
		{
			Console.WriteLine("=== MATH GAME ===");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Multiplication");
			Console.WriteLine("4. Division");
			Console.WriteLine("5. Game History");
			Console.WriteLine("0. Exit");

			Console.WriteLine("Please choose an option!");
			string? option = Console.ReadLine();

			switch (option)
			{
				case "1":
					Console.WriteLine("You selected Addition.");
					break;

				case "2":
					Console.WriteLine("You selected Subtraction.");
					break;

				case "3":
					Console.WriteLine("You selected Multiplication.");
					break;

				case "4":
					Console.WriteLine("You selected Division.");
					break;

				case "5":
					Console.WriteLine("You selected Game History.");
					break;

				case "0":
					Console.WriteLine("Goodbye!");
					active = false;
					break;

				default:
					Console.WriteLine("Invalid option. Please try again.");
					break;
			}


		}
	}
}