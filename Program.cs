namespace CirclesLab;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome, master of circles.");
		Console.WriteLine("Please enter the radius for the circle to create:");

		double result;
		while (!double.TryParse(Console.ReadLine(), out result))
			Console.WriteLine("Please enter a valid number");

		Circle circle = new(result);
		circle.Print();
		
		while (PromptYesNo(true, "Would you like to grow the circle?"))
		{
			Console.Clear();
			circle.Grow();
			Console.WriteLine("The circle grew!");
			circle.Print();
			Console.WriteLine();
		}

		Console.WriteLine(" ");
		Console.WriteLine($"Goodbye, and thank you for making a circle with a radius of {circle.GetRadius()}");
		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}

	static bool PromptYesNo(bool allowEscape, string message)
	{
		Console.WriteLine(message + " [Y/N]");

		while (true)
		{
			// get keystroke
			char key = Console.ReadKey().KeyChar;

			// deletes echoed keystroke from output
			Console.Write("\b\\\b");

			// process keystroke
			switch (key)
			{
				// yes
				case 'y':
				case 'Y':
					Console.Clear();
					return true;

				// no
				case 'n':
				case 'N':
					return false;

				// escape key
				case '\x1b':
					if (allowEscape)
						return false;
					break;
			}
		}
	}
}
