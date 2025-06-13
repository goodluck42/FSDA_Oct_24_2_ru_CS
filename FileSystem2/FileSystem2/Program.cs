using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;

var user = new User
{
	Id = 1,
	Login = "admin",
	Password = "pass",
	Rating = 1.9
};

var json = JsonSerializer.Serialize(user);

Console.WriteLine(json);

//////////////////////
// var user1 = new User(1, "admin", "admin", 0.5);
// var user2 = user1 with { Id = 2, Password = "test" };
//
// using var binaryWriter = new BinaryWriter(File.Open("file.bin", FileMode.OpenOrCreate));
//
// binaryWriter.Write(user1.Id);
// binaryWriter.Write(user1.Login);
// binaryWriter.Write(user1.Password);
// binaryWriter.Write(user1.Rating);
//
// Console.WriteLine(user1);
//////////////////

// using var binaryReader = new BinaryReader(File.Open("file.bin", FileMode.OpenOrCreate));
//
// int id = binaryReader.ReadInt32();
// string login = binaryReader.ReadString();
// string password = binaryReader.ReadString();
// double rating = binaryReader.ReadDouble();
//
// var user = new User
// {
// 	Id = id,
// 	Login = login,
// 	Password = password,
// 	Rating = rating
// };
//
// Console.WriteLine(user);

// record User(int Id, string Login, string Password, double Rating);

var user2 = new User {
	Id = 1,
	Login = "admin",
	Password = "pass",
	Rating = 1.9
};

using var memoryStream = new MemoryStream();
using var binaryWriter = new BinaryWriter(memoryStream);

binaryWriter.Write(user2.Id);
binaryWriter.Write(user2.Login);
binaryWriter.Write(user2.Password);
binaryWriter.Write(user2.Rating);

using var file = File.Open("user.bin", FileMode.OpenOrCreate);

memoryStream.WriteTo(file);

class User
{
	[JsonPropertyName("_id")]
	public int Id { get; set; }
	public string Login { get; set; } = null!;
	public string Password { get; set; } = null!;
	
	[JsonIgnore]
	public double Rating { get; set; }
}