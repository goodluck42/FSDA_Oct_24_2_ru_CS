IMoveable[] world = new IMoveable[3];

world[0] = new Dog();
world[1] = new Cat();
world[2] = new Bicycle();

// type casting & type conversion


WhoIsIt(world[0]);

void WhoIsIt(IMoveable moveableObject)
{
	// if (moveableObject is Dog dog)
	// {
	// 	Console.WriteLine("This is a dog");
	// 	
	// 	dog.Bark();
	// }

	try
	{
		Cat cat = (Cat)moveableObject;
	}
	catch (InvalidCastException ex)
	{
		Console.WriteLine(ex.Message);
	}
}


///////////////////
// IB obj = new MyClass();
//
// obj.Foo();
///////////////////

// ICountable counter = new MyCounter();
//
// counter.Add();
//
// Console.WriteLine(counter.Counter);

void MoveForward(IMoveable moveableObject)
{
	moveableObject.Move();
}

interface IMoveable
{
	void Move();
}

abstract class Animal
{
	public abstract void Voice();
}

class Dog : Animal, IMoveable
{
	public int Age { get; set; }
	public override void Voice()
	{
		Console.WriteLine("Dog.Voice");
	}

	public void Bark()
	{
		Console.WriteLine("Dog is barking");
	}
	
	public void Move()
	{
		Console.WriteLine("Dog.Move");
	}
}

class Cat : Animal, IMoveable
{
	public override void Voice()
	{
		Console.WriteLine("Cat.Voice");
	}

	public void Move()
	{
		Console.WriteLine("Cat.Move");
	}
}

class Bicycle : IMoveable
{
	public void Move()
	{
		Console.WriteLine("Bicycle.Move");
	}
}

////

class MyClass : IA, IB
{
	public void Foo()
	{
		Console.WriteLine("MyClass.Foo");
	}
	
	void IA.Foo() // explicit implementation
	{
		Console.WriteLine("IA.Foo");
	}

	void IB.Foo() // explicit implementation
	{
		Console.WriteLine("IB.Foo");
	}
}

interface IA
{
	void Foo();
}

interface IB
{
	void Foo();
}

interface ICountable
{
	int Counter { get; set; }

	void Add()
	{
		Counter += 1;
	}
}

class MyCounter : ICountable
{
	public int Counter { get; set; }
}
