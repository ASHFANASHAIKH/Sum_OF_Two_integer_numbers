using System;

namespace Sum_OF_Two_integer_numbers
{
	public class sum
	{
		public static int Sum(int num1, int num2)
		{
			int sum;
			sum = num1 + num2;
			return sum;
		}
		public static void Main()
		{
			Console.Write("\n Program to calculate sum of two integer numbers:\n");
			Console.Write("-----------------------------------------------------\n");
			Console.Write("Enter first integer number:");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second integer number:");
			int n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nSum of two integer num is: {0}\n" , Sum(n1,n2));

		}
	}
}