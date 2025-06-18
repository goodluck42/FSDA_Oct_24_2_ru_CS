using System.Text.Json;

var users = new List<User>
{
	new User
	{
		Id = 3,
		Login = "snusoed",
		Name = "Analbek"
	},
	new User
	{
		Id = 1,
		Login = "abibas",
		Name = "Abbas Ali"
	},
	new User
	{
		Id = 2,
		Login = "adolf",
		Name = "Maglot Yasper"
	}
}.ToArray();

var sorted = users.OrderBy(u => u.Id).Select(x => x.Id);

foreach (var id in sorted)
{
	Console.WriteLine(id);
}

var min = users.MinBy(x => x.Id);

Console.WriteLine(min is null);

// var names = users.Select(x => new
// {
// 	Id = x.Id,
// 	Login = x.Login,
// });
//
// foreach (var name in names)
// {
// 	Console.WriteLine(name);
// }

// var anon = new
// {
// 	Value = 42,
// 	Data = "Hello World"
// };

// Foo(anon);
// Foo2(anon);
Console.Read();
void Foo2(dynamic obj)
{
	Console.WriteLine(obj.Value);
	Console.WriteLine(obj.Data);
}

void Foo(object obj)
{
	var type = obj.GetType();
	var valueProperty = type.GetProperty("Value");
	var dataProperty = type.GetProperty("Data");
	
	int value = (int)valueProperty!.GetValue(obj)!;
	string data = (string)dataProperty!.GetValue(obj)!;
	
	Console.WriteLine(value);
	Console.WriteLine(data);
	
	// Console.WriteLine(obj.Value);
	// Console.WriteLine(obj.Data);
}


// List<int> list = [-1, -2, -3, -4, 1, 2, 3, 4];
//
//
// var result = list.Where(x =>
// {
// 	Console.WriteLine("pos");
//
// 	return x > 0;
// }).Where(x =>
// {
// 	Console.WriteLine("even");
//
// 	return x % 2 == 0;
// }).ToArray();




// var enumerator = result.GetEnumerator();
//
// while (enumerator.MoveNext())
// {
// 	Console.WriteLine(enumerator.Current);
// }

// foreach (var item in result)
// {
// 	Console.WriteLine($"item: {item}");
// }

// ToJson
static class ObjectExtensions
{
	public static string ToJson(this object source)
	{
		return JsonSerializer.Serialize(source);
	}
}

class User
{
	public int Id { get; set; }
	public string? Login { get; set; }
	public string? Name { get; set; }
}