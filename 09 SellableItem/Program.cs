namespace SellableItem;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("== Car ==");
		ISellableItem car = new Car("Ford", "Focus", "4Y1SL65848Z411439", "Blue");
		Console.WriteLine(car.ProductInfo());
		Console.WriteLine(car.Identifier());

		Console.WriteLine("\n== Phone ==");
		ISellableItem phone = new Phone("Samsung", "Galaxy S21", 987654321);
		Console.WriteLine(phone.ProductInfo());
		Console.WriteLine(phone.Identifier());
	}
}