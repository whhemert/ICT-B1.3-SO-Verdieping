namespace Meerdere_Ervingen;

internal class Animal
{
	private string _name;
	private DateOnly _dateOfBirth;

	public Animal(string name, DateOnly dateOfBirth)
	{
		_name = name;
		_dateOfBirth = dateOfBirth;
	}

	public virtual void PrintInfo()
	{
		Console.WriteLine($"Name: {_name}");
		Console.WriteLine($"Date of birth: {_dateOfBirth}");
	}
}
