using System;

class Line_equals
{
	public static void Main()
	{
		int X, Y;
		Console.Write("Check Equality of 2 Length\n");
		Console.Write("------------------------------------------------------");
		Console.Write("\n\n");

		Console.Write("Enter the value for X coordinate :");
		X = Convert.ToInt16(Console.ReadLine());
		Console.Write("Enter the value for Y coordinate :");
		Y = Convert.ToInt16(Console.ReadLine());

		if (X.Equals(Y))
		{
			Console.WriteLine("Lines are equal");
		}
		else
		{
			Console.WriteLine("Lines are not equal");
		}
	}
}
