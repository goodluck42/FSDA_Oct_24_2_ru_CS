static class PersonHelper
{
	public static bool IsAgeValid(int age)
	{
		if (age > 0 && age < 200)
		{
			return true;
		}
		
		return false;
	}

	static PersonHelper()
	{
		Console.WriteLine("Static Constructor");
	}
}