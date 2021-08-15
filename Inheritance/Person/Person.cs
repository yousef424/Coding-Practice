using System;

namespace Person
{
    class Person
    {

        
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person()
		{ }
		public Person(string firstName, string lastName, int identification)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
			//Person.name++;
		}
		public  void printPerson()
		{
			//Console.WriteLine(Person.name);
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}
	}
}
