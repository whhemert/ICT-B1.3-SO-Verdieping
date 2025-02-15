namespace StaticItems
{
	internal class Person
	{
		private string _name;
		// static yiels a possible problem
		//private static int _age;
		private int _age;

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

		// in case the age is equal person2 will be returned
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
