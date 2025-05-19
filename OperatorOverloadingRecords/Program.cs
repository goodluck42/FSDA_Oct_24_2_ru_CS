// string str = Console.ReadLine(); // null forgiving operator
//
// Console.WriteLine(str.Length);

// string s = null;
// int? a = null;

// string ToUpper(string? str)
// {
// 	if (str == null)
// 	{
// 		return string.Empty;
// 	}
// 	
// 	return str.ToUpper();
// }

var num1 = new Number(90);
var num2 = new Number(90);
var num3 = num1 + num2;

if (num1.Equals(num2))
{
	Console.WriteLine("equals");
}
else
{
	Console.WriteLine("not equals");
}


class Number
{
	private int _value;

	public Number()
	{
		_value = 0;
	}
	
	public Number(int value)
	{
		
	}

	public void Print()
	{
		Console.WriteLine($"Current value: {_value}");
	}
	// += 
	public static Number operator+(Number left, Number right)
	{
		var result = new Number();

		result._value = left._value = right._value;
		
		return result;
	}

	public override bool Equals(object? obj)
	{
		if (obj is Number result)
		{
			return result._value == _value;
		}

		return false;
	}

	// public static bool operator==(Number left, Number right)
	// {
	// 	return left._value == right._value;
	// }
	//
	// public static bool operator!=(Number left, Number right)
	// {
	// 	return !(left == right);
	// }
}


