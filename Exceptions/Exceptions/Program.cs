


// var cup = new Cup();
//
// cup.Volume = -20;
// // cup.Size = 20;
//
// Console.WriteLine(cup.ToString());
// Console.WriteLine(cup.Size);
// Console.WriteLine(cup.Volume);
// Console.WriteLine(Cup._constValue);
//
// class Person {}
//
// class Cup
// {
// 	private readonly int _readonlyValue; // const int* 
// 	public const int _constValue = 9; // constexpr int
// 	
// 	// public void ChangeSize()
// 	// {
// 	// 	_readonlyValue = 20;
// 	// 	_constValue = 20;
// 	// 	
// 	// 	++Size;
// 	// }
// 	
// 	public Cup() : this(0, 1)
// 	{
// 		
// 	}
//
// 	public Cup(int volume, int size)
// 	{
// 		_volume = volume;
// 		Size = size;
// 	}
// 	
// 	private double _volume;
//
// 	public double Volume
// 	{
// 		get { return _volume; }
// 		set
// 		{
// 			_volume = Math.Clamp(value, 0, 100);
// 		}
// 	}
// 	
// 	public int Size { get; private set; } // readonly property
// }



// var calc = new Calculator();
//
// double n1, n2;
//
// n1 = double.Parse(Console.ReadLine());
// n2 = double.Parse(Console.ReadLine());
//
// try
// {
// 	double result = calc.Divide(n1, n2);
//
// 	Console.WriteLine($"result = {result}");
// }
// catch (ZeroDivisionException ex)
// {
// 	Console.WriteLine(ex.Message);
// }



	
// Console.WriteLine("Enter path -> ");
// string path = null;
//
// try
// {
// 	Directory.Delete(path, true);
// }
// catch (DirectoryNotFoundException ex)
// {
// 	Console.WriteLine($"Message: {ex.Message}");
// 	Console.WriteLine($"HelpLink: {ex.HelpLink}");
// }
// catch (ArgumentNullException)
// {
// 	Console.WriteLine("Path is null!");
// }
// catch (Exception)
// {
// 	Console.WriteLine("An exception was thrown!");
// }

int[] arr1 = new int[5] {10, 20, 30, 40, 50};
int[] arr2 = new int[3] {20, 40, 50};

int filterCount = 0;

for (int i = 0; i < arr1.Length; i++)
{
	for (int j = 0; j < arr2.Length; j++)
	{
		if (arr1[i] == arr2[j])
		{
			filterCount++;
		}
	}
}

int[] filteredArray = new int[arr1.Length - filterCount];

Console.WriteLine(filterCount);

for (int i = 0; i < arr1.Length; i++)
{
	for (int j = 0; j < arr2.Length; j++)
	{
		if (arr1[i] == arr2[j])
		{
			filterCount++;
		}
	}
}


