// PascalCase
// camelCase

class Program
{
	static void Main(string[] args)
	{
		// bool - 1b
		// byte - 1b
		{
			byte b1 = 255; // 0-255
			sbyte b2 = 127; // -128 - 127
		}
		
		// char - 2b
		// short - 2b
		// {
		// 	ushort us = 50000;
		// }
		
		// int / uint - 4b
		// float - 4b
		
		// long / ulong - 8b
		// double - 8b
		
		// decimal - 16b
		
		// decimal a = 0.1m;
		// decimal b = 0.2m;
		//
		// Console.WriteLine(a + b);

		//// if else if else
		// int a = 42;
		//
		// if (a % 2 == 0)
		// {
		// 	
		// }
		// else if (a % 2 != 0)
		// {
		// 	
		// }
		// else
		// {
		// 	
		// }
		
		//// do while
		// string name = Console.ReadLine();
		//
		// switch (name)
		// {
		// 	case "Alex":
		// 		Console.WriteLine("Me");
		// 		break;
		// 	case "Emi":
		// 		Console.WriteLine("We");
		// 		goto case "Alex";
		// 		break;
		// 	default:
		// 		Console.WriteLine("This is default!");
		// 		break;
		// }
		//
		// int value = 10;
		//
		// switch (value)
		// {
		// 	case > 10 and < 100:
		// 		Console.WriteLine("More than 10");
		// 		break;
		// }
		
		//// Loops
		// {
		// 	// for (var i = 0; i < 10; i++)
		// 	// {
		// 	// 	Console.WriteLine(i);
		// 	// }
		// 	
		// 	// int i = 0;
		// 	//
		// 	// while (i < 10)
		// 	// {
		// 	// 	Console.WriteLine(i);
		// 	// 	++i;
		// 	// }
		//
		// 	int i = 0;
		//
		// 	do
		// 	{
		// 		Console.WriteLine(i++);
		// 	} while (false);
		// }
		
		Console.WriteLine("Enter first number -> ");
		int value1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter second number -> ");
		int value2 = int.Parse(Console.ReadLine());

		Console.WriteLine(value1 + value2);
	}
}


// .NET Framework 4.8.2 (Windows only)
// .NET Core 1 - 3.2 (Cross platform)
// .NET 5 - .NET 9 (Cross platform)
// .NET Standard


// C#, F#, Visual Basic, C++
// CLS - Common Language Specification
// CTS - Common Type System
// BCL / FCL - Base Class Library / Framework Class Library







