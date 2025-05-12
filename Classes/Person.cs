class Person
{
	public Person() : this(0, string.Empty)
	{
		
	}

	public Person(int age, string name)
	{
		Age = age;
		Name = name;
	}
	
	private int _age; // backing field
	
	public int Age // full property
	{
		get
		{
			Console.WriteLine("getter");
			
			return _age;
		}
		set
		{
			Console.WriteLine("setter");
			
			if (PersonHelper.IsAgeValid(value))
			{
				_age = value;
			}
		}
	}
	
	public string Name { get; set; } // auto property
	
	public const string DefaultName = "N/A";
	// public const int Value = 42;
	// public const int[] Value2 = new int[3];
}


