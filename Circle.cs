namespace CirclesLab
{
	public class Circle
	{
		private double radius;
		public Circle(double radius)
		{
			this.radius = radius; 
		}

		public double CalculateDiameter()
		{
			return radius * 2.0;
		}

		public double CalculateCircumference()
		{
			return 2.0 * Math.PI * radius;
		}

		public double CalculateArea()
		{
			return Math.PI * radius * radius;
		}

		public void Grow()
		{
			radius *= 2.0;
		}

		public double GetRadius()
		{
			return radius;
		}

		public void Print()
		{
			Console.WriteLine("Diameter:      \t" + CalculateDiameter());
			Console.WriteLine("Circumference: \t" + CalculateCircumference());
			Console.WriteLine("Area:          \t" + CalculateArea());
		}
	}
}
