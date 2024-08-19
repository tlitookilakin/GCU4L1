namespace CirclesLab;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome, master of circles.");
		Console.WriteLine("Please enter the radius for the circle to create:");

		Circle circle = new(Utility.GetDouble());
		circle.Print();
		
		while (Utility.PromptYesNo(true, "Would you like to grow the circle?"))
		{
			Console.Clear();
			circle.Grow();
			Console.WriteLine("The circle grew!");
			circle.Print();
			Console.WriteLine();
		}

		Utility.PromptExit($"Goodbye, and thank you for making a circle with a radius of {circle.GetRadius()}");
	}
}
