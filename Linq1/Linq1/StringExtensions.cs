namespace Linq1;

static class StringExtensions
{
	public static string Capitalize(this string source)
	{
		if (source.Length >= 2)
		{
			return char.ToUpper(source[0]) + source[1..];
		}

		if (source.Length == 1)
		{
			return source.ToUpper();
		}

		return string.Empty;
	}

	// public static string Capitalize(this string source) => source.Length >= 2 ? char.ToUpper(source[0]) + source[1..] : source.Length == 1 ? source.ToUpper() : string.Empty;
}

static partial class EnumerableExtensions
{
	public static void Print<T>(this IEnumerable<T> source, int limit)
	{
		int i = 0;
		
		foreach (var item in source)
		{
			if (i++ == limit)
			{
				break;
			}
			
			Console.WriteLine(item);
		}
	}
}


static partial class EnumerableExtensions
{
	public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
	{
		foreach (var item in source)
		{
			if (!predicate(item))
			{
				yield break;
			}
			
			if (predicate(item))
			{
				yield return item;
			}
		}
	}
	
	// public static IEnumerable<int> GetValues()
	// {
	// 	for (int i = 0; i < 5; ++i)
	// 	{
	// 		Console.WriteLine($"checkpoint {i}");
	// 	
	// 		yield return (i + 1) * 10;
	// 	}
	// }
}