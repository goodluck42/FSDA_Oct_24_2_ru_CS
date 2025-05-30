using Delegates;


////////// Delegates 1
int a, b;
char op;

Console.WriteLine("Enter first number: ");
a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter operation (+, *, /)");
op = char.Parse(Console.ReadLine()!);

Console.WriteLine("Enter second number: ");
b = int.Parse(Console.ReadLine()!);

Operation? operation = null;

switch (op)
{
	case '+':
		operation = Functions.Add;
		break;
	case '*':
		operation = Functions.Multiply;
		break;
	case '/':
		operation = Functions.Divide;
		break;
	case '-':
		operation = (num1, num2) =>
		{
			return num1 - num2;
		};
		
		break;
}

int? result = operation?.Invoke(a, b);
	
Console.WriteLine(result);


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

CallbackDelegate callbackDelegates1 = () =>
{
	Console.WriteLine("Delegate 1");

	return 1;
};



callbackDelegates1 += () =>
{
	Console.WriteLine("Delegate 2");

	return 2;
};

callbackDelegates1 += () =>
{
	Console.WriteLine("Delegate 3");

	return 3;
};

CallbackDelegate callbackDelegates2 = () =>
{
	Console.WriteLine("Delegate 4");

	return 4;
};

callbackDelegates2 += () =>
{
	Console.WriteLine("Delegate 5");

	return 5;
};

callbackDelegates2 += () =>
{
	Console.WriteLine("Delegate 6");

	return 6;
};

callbackDelegates1 += callbackDelegates2;


callbackDelegates1?.Invoke();