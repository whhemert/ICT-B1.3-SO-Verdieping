namespace StaticItems;

class Program
{
	static void Main()
	{
		Person person1 = new Person("Alice", 30);
		Person person2 = new Person("Bob", 40);

		Console.WriteLine($"person1: {person1}");
		Console.WriteLine($"person2: {person2}");

		Person oldest = Person.Oldest(person1, person2);
		Console.WriteLine($"The oldest person is: {oldest}");
	}
}