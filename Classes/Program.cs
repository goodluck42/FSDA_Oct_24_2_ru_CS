class Program
{
	static void Main(string[] args)
	{
		Person person = new Person
		{
			Age = 25,
			Name = "Alex"
		};

		Console.WriteLine(person.Name);
		Console.WriteLine(person.Age);

		Console.WriteLine(Person.DefaultName);
	}
}