using System;

class Line_equals
{
	public static void Main()
	{
		int X, Y;
		Console.Write("Compare Line\n");
		Console.Write("------------------------------------------------------");
		Console.Write("\n\n");

		Console.Write("Enter the value for X coordinate :");
		X = Convert.ToInt16(Console.ReadLine());
		Console.Write("Enter the value for Y coordinate :");
		Y = Convert.ToInt16(Console.ReadLine());
		int compare_value = X.CompareTo(Y);
		Console.WriteLine(compare_value);
		if (compare_value==0)
		{
			Console.WriteLine("Both Lines are equal");
		}
		else if (compare_value < 0)
		{
			Console.WriteLine("X is less than Y");
		}
		else if (compare_value > 0)
		{
			Console.WriteLine("X is Greater than Y");
		}
	}
}