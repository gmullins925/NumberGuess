using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
	class Program
	{
		static void Main(string[] args)

		{
			do
			{
			Random random = new Random();

			int returnValue = random.Next(1, 100);

			int Guess = 0;

			Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

			while (Guess != returnValue)
			{
				Guess = Convert.ToInt32(Console.Read());

				if (Guess < returnValue)
				{
					Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
				}
				else if (Guess > returnValue)
				{
					Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
				}

			}
			Console.WriteLine("Well done! The answer was " + returnValue);

				Console.WriteLine("Would you like to guess another number?");
			}
			while ((Console.ReadLine() == "Y") || (Console.ReadLine() == "y"));
			Console.ReadLine();
		}
	}
}
