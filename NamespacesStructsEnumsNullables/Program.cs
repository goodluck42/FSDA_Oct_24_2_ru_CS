global using System.Text.Json;
using NamespacesStructsEnumsNullables;
using NamespacesStructsEnumsNullables.Models;

////////// Namespaces
// using NamespacesStructsEnumsNullables.Models;
//
// var user = new User();
// var user2 = new NamespacesStructsEnumsNullables2.User();
//
// var anon = new
// {
// 	Id = 42,
// 	Name = "Emily"
// };
//
// var json = JsonSerializer.Serialize(anon);
//
// Console.WriteLine(json);


////////// Enums
// using NamespacesStructsEnumsNullables.Enums;
//
// int enumValue = int.Parse(Console.ReadLine());
//
// Direction dir = (Direction)enumValue;
//
// switch (dir)
// {
// 	case Direction.Forward:
// 		break;
// 	case Direction.Left:
// 		break;
// 	case Direction.Backward:
// 		break;
// 	case Direction.Right:
// 		break;
// }

////////// Structs vs Classes

//// Classes
// var user = new User
// {
// 	FirstName = "Emi",
// 	Id = 1
// };
//
// ChangeUser(ref user);
// PrintUser(user);
//
// void ChangeUser(ref User user) // void ChangeUser(User*& user)
// {
// 	user = new User
// 	{
// 		Id = 2,
// 		FirstName = "Mika"
// 	};
// }
//
// void PrintUser(User user)
// {
// 	Console.WriteLine(user.Id);
// 	Console.WriteLine(user.FirstName);
// }

//// Structs

Vector3 vect = new Vector3
{
	X = 1.42f,
	Y = 9.6f,
	Z = 3.34f
};

MoveVector3(vect);
PrintVector3(vect);

void MoveVector3(Vector3 vector)
{
	// vector.X++;
	// vector.Y++;
	// vector.Z++;
}

void PrintVector3(Vector3 vector)
{
	Console.WriteLine(vector.X + " " + vector.Y + " " + vector.Z);
}