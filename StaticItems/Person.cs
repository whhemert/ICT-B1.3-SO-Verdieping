﻿namespace StaticItems
{
	public class Person
	{
		private string _name;
		private static int _age;

		public Person(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age
		{
			get { return _age; }
		}

		public static Person Oldest(Person person1, Person person2)
		{
			return person1.Age > person2.Age ? person1 : person2;
		}

		// Override ToString for easy display
		public override string ToString()
		{
			return $"Name: {_name}, Age: {_age}";
		}
	}
}
