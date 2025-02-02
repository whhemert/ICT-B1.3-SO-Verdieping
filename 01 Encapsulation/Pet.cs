namespace Encapsulation;

public class Pet
{
    public Pet(string name) {
        _name = name;
    }

    private string _name;

    public void SetName(string newName)
    {
        if (!string.IsNullOrWhiteSpace(newName))
        {
            _name = newName;
            Console.WriteLine("Pet name set to: " + _name);
        }
        else
        {
            Console.WriteLine("Name cannot be empty.");
        }
    }
}