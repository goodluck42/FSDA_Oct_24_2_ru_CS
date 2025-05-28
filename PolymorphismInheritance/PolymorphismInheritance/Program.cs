// Animal obj = new Cat();
//
// Console.WriteLine(obj.GetClassName());


string? name = GetName() ?? "n/a"; // null coalescing operator

//name?.ToString(); // null conditional operator

Console.WriteLine(name?.Length); // null conditional operator
Console.WriteLine(name);


if (name != null)
{
	Console.WriteLine(name.Length);
}

string? GetName()
{
	if (Random.Shared.Next(0, 2) == 1)
	{
		return "Alex";
	}

	return null;
}


abstract class Animal
{
	public abstract void Voice(); // public: void Voice() = 0;

	public virtual void Print()
	{
		Console.WriteLine(GetClassName());
	}
	
	public string GetClassName()
	{
		return GetType().Name;
	}

	public abstract string Name { get; set; }
}

class Dog : Animal
{
	private string? _name;

	public override void Voice()
	{
		Console.WriteLine("Dawg");
	}

	public override string Name
	{
		get => _name ?? throw new InvalidOperationException("Name is not set.");
		
		set
		{
			if (char.IsLower(value[0]))
			{
				throw new InvalidOperationException("Dog name should start with upper case");
			}
			
			_name = value;
		}
	}
}

class Cat : Animal
{
	private string _name = string.Empty;

	public override void Voice()
	{
		Console.WriteLine("Meow-meow");
	}

	public override string Name
	{
		get => _name;
		set => _name = value;
	}
}