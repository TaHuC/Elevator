using System;

namespace Elevator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int maxPerson = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());

			int courses = (int)Math.Ceiling((double)maxPerson / capacity);

			Console.WriteLine(courses);
		}
	}
}
