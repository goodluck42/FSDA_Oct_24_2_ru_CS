namespace SOLID.Models;

class Game
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public List<string> Genres { get; set; } = [];
	// ...
}