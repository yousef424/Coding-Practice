using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Student : Person
	{
		public int[] testScores;
		public Student(string firstName, string lastName, int identification, int[] scores)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
			this.testScores = scores;
		}

		public char Claculate()
		{
			int sum = 0;
			int average = 0;
			for (int i = 0; i < testScores.Length; i++)
			{
				sum += testScores[i];
            }
			average = sum / (testScores.Length);
			Console.WriteLine(average);

			if (average <= 100 && average >= 90)
            {
				return 'O';
            }
			else if (average < 90 && average >= 80)
			{
				return 'E';

			}
			else if (average < 80 && average >= 70)
			{
				return 'A';

			}
			else if (average < 70 && average >= 55)
			{
				return 'P';

			}
			else if (average <55 && average >= 40)
			{
				return 'D';

			}
			else if (average <40)
			{
				return 'T';

			}
			else
			return 'N';

		}
	}
}
