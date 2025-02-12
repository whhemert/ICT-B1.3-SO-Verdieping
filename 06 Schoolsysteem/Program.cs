namespace Schoolsysteem
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("== student ==");
			Student student = new Student("Jan", "Peters", new DateOnly(2006, 5, 17), 101001);
			student.PrintInfo();

			Console.WriteLine("\n== docent ==");
			Persoon docent = new Docent("Fred", "Fakkel", new DateOnly(2002, 6, 17), 202002, 2000.00);
			docent.PrintInfo();

			Console.WriteLine("\n== receptionist ==");
			Persoon receptionist = new Receptionist("Peter", "Janssen", new DateOnly(1978, 3, 1), 564654, 1500.00, "Avans Lovensdijkstraat");
			receptionist.PrintInfo();
		}
	}
}