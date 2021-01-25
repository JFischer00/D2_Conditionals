using System;

namespace D2_Conditionals
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What grade do you expect to receive in ISM 4300?");

			if (int.TryParse(Console.ReadLine(), out int expectedGrade))
			{
				string letterGrade = "";
				if (expectedGrade >= 0 && expectedGrade < 60)
					letterGrade = "F";
				else if (expectedGrade < 62)
					letterGrade = "D-";
				else if (expectedGrade < 68)
					letterGrade = "D";
				else if (expectedGrade < 70)
					letterGrade = "D+";
				else if (expectedGrade < 72)
					letterGrade = "C-";
				else if (expectedGrade < 78)
					letterGrade = "C";
				else if (expectedGrade < 80)
					letterGrade = "C+";
				else if (expectedGrade < 82)
					letterGrade = "B-";
				else if (expectedGrade < 88)
					letterGrade = "B";
				else if (expectedGrade < 90)
					letterGrade = "B+";
				else if (expectedGrade < 92)
					letterGrade = "A-";
				else if (expectedGrade < 98)
					letterGrade = "A";
				else if (expectedGrade <= 100)
					letterGrade = "A+";
				else
					Console.WriteLine("You must enter a numerical grade between 0 and 100!");

				if (letterGrade != "")
					Console.WriteLine($"You expect to receive a letter grade of {letterGrade} in ISM 4300. Good luck this semester!");

			}
			else
			{
				Console.WriteLine("You must enter a numerical grade between 0 and 100!");
			}
		}
	}
}
