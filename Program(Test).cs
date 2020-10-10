using System;
using CalculatorLibrary;

namespace Test
{

	class Program
	{
		static void Main(string[] args)
		{

			Calculator calculator = new Calculator();
			double result = 0;
			try
			{


				result = calculator.DoOperation(12.0, 4.0, "a");
				Console.WriteLine("Test Case 1 (12.0 + 4.0 = {0:0.##})\n", result);
				result = calculator.DoOperation(12.0, 4.0, "s");
				Console.WriteLine("Test Case 2 (12.0 - 4.0 = {0:0.##})\n", result);
				result = calculator.DoOperation(12.0, 4.0, "m");
				Console.WriteLine("Test Case 3 (12.0 * 4.0 = {0:0.##})\n", result);
				result = calculator.DoOperation(12.0, 4.0, "d");
				Console.WriteLine("Test Case 4 (12.0 / 4.0 = {0:0.##})\n", result);

				result = calculator.DoOperation(18.4, 3.4, "a");
				Console.WriteLine("Test Case 5 (18.4 + 3.4 = {0:0.##})\n", result);
				result = calculator.DoOperation(18.4, 3.4, "s");
				Console.WriteLine("Test Case 6 (18.4 - 3.4 = {0:0.##})\n", result);
				result = calculator.DoOperation(18.4, 3.4, "m");
				Console.WriteLine("Test Case 7 (18.4 * 3.4 = {0:0.##})\n", result);
				result = calculator.DoOperation(18.4, 3.4, "d");
				Console.WriteLine("Test Case 8 (18.4 / 3.4 = {0:0.##})\n", result);

				result = calculator.DoOperation(5.4, 0.0, "a");
				Console.WriteLine("Test Case 9 (5.4 + 0.0 = {0:0.##})\n", result);
				result = calculator.DoOperation(5.4, 0.0, "s");
				Console.WriteLine("Test Case 10 (5.4 - 0.0 = {0:0.##})\n", result);
				result = calculator.DoOperation(5.4, 0.0, "m");
				Console.WriteLine("Test Case 11 (5.4 * 0.0 = {0:0.##})\n", result);
				result = calculator.DoOperation(5.4, 0.0, "d");
				Console.WriteLine("Test Case 12 (5.4 / 0.0 = {0:0.##})\n", result);


			}
			catch (Exception e)
			{
				Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
			}

			calculator.Finish();


			return;
		}
	}
}

