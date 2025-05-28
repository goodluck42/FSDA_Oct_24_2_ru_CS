using Delegates;


////////// Delegates 1
// int a, b;
// char op;
//
// Console.WriteLine("Enter first number: ");
// a = int.Parse(Console.ReadLine()!);
//
// Console.WriteLine("Enter operation (+, *, /)");
// op = char.Parse(Console.ReadLine()!);
//
// Console.WriteLine("Enter second number: ");
// b = int.Parse(Console.ReadLine()!);
//
// Operation? operation = null;
//
// switch (op)
// {
// 	case '+':
// 		operation = Functions.Add;
// 		break;
// 	case '*':
// 		operation = Functions.Multiply;
// 		break;
// 	case '/':
// 		operation = Functions.Divide;
// 		break;
// 	case '-':
// 		operation = (num1, num2) => num1 - num2;
// 		
// 		break;
// }
//
// int? result = operation?.Invoke(a, b);
// 	
// Console.WriteLine(result);


///////////////// Lambdas
// Operation op = (int a, int b) => a - b; // return a - b;
// Init initDelegate = value => value = 42; // no return here
// NoParamDelegate anotherDelegate = () => Console.WriteLine("Hello World!");
//
// Console.WriteLine(op(5, 2));
//
// anotherDelegate();

// Турал, Ряван, Рихад - 1
// Наиль, Эля - 2
// Нармин - 3

////////// Multicast Delegates
CallbackDelegate callbackDelegate = () =>
{
	Console.WriteLine("First");

	return 1;
};

callbackDelegate += () =>
{
	Console.WriteLine("Second");

	return 2;
};

callbackDelegate += () =>
{
	Console.WriteLine("Third");

	return 3;
};

callbackDelegate += () =>
{
	Console.WriteLine("Fourth");

	return 4;
};

Console.WriteLine(callbackDelegate?.Invoke());