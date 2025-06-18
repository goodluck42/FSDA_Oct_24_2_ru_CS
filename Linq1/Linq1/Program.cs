// using Linq1;
// using Bogus;
//
//
// // string name = "alex";
// //
// // var cap = name.Capitalize();
// //
// // Console.WriteLine(cap);
// //
// // var list = new List<string>();
// //
// // list.Add("a");
// // list.Add("b");
// // list.Add("c");
// // list.Print(2);
//
// // Select, Where, Min, Max
// // First, Last, 
//
// // var faker = new Faker<User>();
// //
// // int i = 1;
// //
// // faker.RuleFor(x => x.Id, f => i++)
// // 	.RuleFor(x => x.Name, f => f.Name.FirstName())
// // 	.RuleFor(x => x.Bans, f => Random.Shared.Next(0, 5))
// // 	.RuleFor(x => x.Login, f => f.Internet.Email())
// // 	.RuleFor(x => x.RegDate, x => x.Date.Past())
// // 	.RuleFor(x => x.Rating, x => Random.Shared.NextSingle());
// //
// // List<User> users = faker.Generate(5);
// //
// // foreach (var user in users)
// // {
// // 	PrintUser(user);
// // 	Console.WriteLine("---------------------");
// // }
// //
// // Console.WriteLine("---------------------");
// // Console.WriteLine("---------------------");
//
// // First & FirstOrDefault, Last & LastOrDefault
// // {
// // 	string name = Console.ReadLine()!;
// //
// // 	User? foundUser = users.FirstOrDefault(x => x.Name == name);
// //
// // 	if (foundUser == null)
// // 	{
// // 		Console.WriteLine("User not found");
// // 	}
// // 	else
// // 	{
// // 		Console.WriteLine("Found user: ");
// //
// // 		PrintUser(foundUser);
// // 	}
// // }
//
// // Where
// // {
// // 	float rating = float.Parse(Console.ReadLine()!);
// //
// // 	// deferred execution
// // 	var filtered = users.Where(x => x.Rating > rating);
// //
// // 	foreach (var user in filtered)
// // 	{
// // 		
// // 	}
// // }
//
// //  MyWhere
// // {
// // 	var list = new List<int> { 10, -13, 20, -30, -40, 42, 50, 60, 61, -69, 70, -80, 99 };
// // 	
// // 	var negativeNumbers = list.MyWhere(x =>
// // 	{
// // 		Console.WriteLine("iteration");
// // 	
// // 		return x < 0;
// // 	});
// //
// // 	// foreach (var number in negativeNumbers)
// // 	// {
// // 	// 	Console.WriteLine(number);
// // 	// }
// // }
//
// {
// 	// IEnumerable<int> vals = EnumerableExtensions.GetValues();
// 	//
// 	// var enumerator = vals.GetEnumerator();
// 	//
// 	// while (enumerator.MoveNext())
// 	// {
// 	// 	var item = enumerator.Current;
// 	//
// 	// 	Console.WriteLine(item);
// 	// }
// }
//
// {
// 	var list = new List<int> { 10, 13, 20, -30, -40};
// 	
// 	var negativeNumbers = list.MyWhere(x =>
// 	{
// 		Console.WriteLine("iteration");
// 	
// 		return x < 0;
// 	});
//
// 	// list.Skip(5).Take(2);
// 	// list.SkipWhile(x => x > 0);
// 	// list.TakeWhile(x => x > 0);
//
// 	bool result = list.Any(x => x == -30);
// 	
// 	IEnumerable<int> with69 = list.Append(-69);
//
// 	foreach (var item in with69)
// 	{
// 		Console.WriteLine(item);
// 	}
// }
//
// void PrintUser(User user)
// {
// 	Console.WriteLine(user.Id);
// 	Console.WriteLine(user.Login);
// 	Console.WriteLine(user.Name);
// 	Console.WriteLine(user.RegDate);
// 	Console.WriteLine(user.Bans);
// 	Console.WriteLine(user.Rating);
// }

using System.Dynamic;
using System.Text.Json;

var jsonObject = new
{
	Test1 = 42,
	Test2 = "String"
};

var json = JsonSerializer.Serialize(jsonObject);

dynamic? obj = JsonSerializer.Deserialize<ExpandoObject>(json);

if (obj is null)
{
	return;
}

Console.WriteLine(obj.Test1);
Console.WriteLine(obj.Test2);

