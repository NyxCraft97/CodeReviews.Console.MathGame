namespace mathGame;
class Program
{
	public static void Main ()
	{
		List<string> gameHistory = new List<string>();

		var active = true;
		while (active)
		{
			Console.WriteLine ("=== MATH GAME ===");
			Console.WriteLine ("1. Addition");
			Console.WriteLine ("2. Subtraction");
			Console.WriteLine ("3. Multiplication");
			Console.WriteLine ("4. Division");
			Console.WriteLine ("5. Game History");
			Console.WriteLine ("0. Exit");

			Console.WriteLine ("Please choose an option!");
			string? option = Console.ReadLine ();

			switch (option)
			{
				case "1":
					game ('+', gameHistory);
					break;

				case "2":
					game ('-', gameHistory);
					break;

				case "3":
					game ('*', gameHistory);
					break;

				case "4":
					game ('/', gameHistory);
					break;

				case "5":
					Console.WriteLine ("Your game history this session is:");
					if(gameHistory.Count == 0)
					{
						Console.WriteLine("No game played yet");
					}
					else
					{
						foreach(string result in gameHistory)
						{
							Console.WriteLine(result);
						}
					}
					break;

				case "0":
					Console.WriteLine ("Goodbye!");
					active = false;
					break;

				default:
					Console.WriteLine ("Invalid option. Please try again.");
					break;
			}
		}
	}

	static void game (char choice, List<string> gameHistory)
	{
		Random random = new Random ();

		int score = 0;
		const int totalQuestions = 5;

		for (int i = 0; i < totalQuestions; i++)
		{
			int num1, num2, correctAnswer;

			switch (choice)
			{
				case '+':
					num1 = random.Next (0, 101);
					num2 = random.Next (0, 101);
					correctAnswer = num1 + num2;
					break;

				case '-':
					num1 = random.Next (0, 101);
					num2 = random.Next (0, 101);
					correctAnswer = num1 - num2;
					break;

				case '*':
					num1 = random.Next (0, 101);
					num2 = random.Next (0, 101);
					correctAnswer = num1 * num2;
					break;

				case '/':
					//generates new numbers until a valid combination shows up
					do
					{
						num1 = random.Next (0, 101);
						num2 = random.Next (0, 101);
					} while (num2 == 0 || num1 % num2 != 0);
					correctAnswer = num1 / num2;
					break;
				
				//i will be incredibly surprised if somehow this part triggers.
				default:
					Console.WriteLine ("Unknown game mode.");
					return;
			}

			Console.WriteLine ($"Question {i+1}: {num1} {choice} {num2} = ?");
			Console.Write ("Your answer: ");
			string? input = Console.ReadLine ();

			if (int.TryParse (input, out int userAnswer) && userAnswer == correctAnswer)
			{
				Console.WriteLine ("Correct!");
				score++;
			}
			else
			{
				Console.WriteLine ($"Incorrect! The answer was {correctAnswer}.");
			}
		}

		string victory;

		if(score >= (totalQuestions/2) + 1)
		{
			Console.WriteLine ($"You win! Your score: {score}/{totalQuestions}");
			victory = "Win";
		}
		else 
		{
			Console.WriteLine ($"You Lose... Your score: {score}/{totalQuestions}");
			victory = "Lose";
		}
		
		var result = $"Mode: {choice} | Score: {score}/{totalQuestions} | {victory}";
		gameHistory.Add(result);
	}
}