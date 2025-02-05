﻿namespace Schoolsysteem
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Waarom werkt dit niet 1?
			// Persoon persoon = new Persoon("William", "van Hemert", new DateOnly(1984, 10, 11));
			// persoon.Levensdoel();
			// Console.WriteLine(persoon.PersoonInfo());

			// Waarom werkt dit niet 2?
			// Medewerker medewerker = new Medewerker("William", "van Hemert", new DateOnly(1984, 10, 11), 202002, 2000.00);
			// medewerker.Levensdoel();
			// Console.WriteLine(medewerker.PersoonInfo());

			Console.WriteLine("== student ==");
			Student student = new Student("Pieter", "Peters", new DateOnly(2006, 5, 17), 101001);
			student.ActiviteitOfDoel();

			Console.WriteLine("== docent1 ==");
			Persoon docent1 = new Docent("William", "van Hemert", new DateOnly(1984, 10, 17), 202002, 2000.00);
			Console.WriteLine(docent1.ActiviteitOfDoel());

			Console.WriteLine("== docent2 ==");
			Docent docent2 = new Docent("William", "van Hemert", new DateOnly(1984, 10, 17), 202002, 2000.00);
			Console.WriteLine(docent2.ActiviteitOfDoel());

			Console.WriteLine("== receptionist1 ==");
			Persoon receptionist1 = new Receptionist("Peter", "Janssen", new DateOnly(1978, 3, 1), 564654, 1500.00, "Lovensdijkstraat 61");
			Console.WriteLine(receptionist1.ActiviteitOfDoel());

			Console.WriteLine("== receptionist2 ==");
			Receptionist receptionist2 = new Receptionist("Peter", "Janssen", new DateOnly(1978, 3, 1), 564654, 1500.00, "Lovensdijkstraat 61");
			Console.WriteLine(receptionist2.ActiviteitOfDoel());
		}
	}
}