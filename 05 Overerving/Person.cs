public class Person
{
    protected string _name;
	protected DateTime _birthDay;

    public Person(string name, DateTime birthDay)
    {
        _name = name;
        _birthDay = birthDay;
    }

    public override string ToString()
	{
		return $"Name: {_name}\nBirth Day: {_birthDay.ToShortDateString()}";
	}
}