using SOLID.Exceptions;
using SOLID.Models;
using SOLID.Services;

namespace SOLID;

static class Ui // Ui - User Interface
{
	private static IGameService _gameService = new GameService();

	private static void AddGame()
	{
		var game = new Game();

		Console.WriteLine("Enter Id: ");
		game.Id = int.Parse(Console.ReadLine()!);

		Console.WriteLine("Enter Name: ");
		game.Name = Console.ReadLine()!;

		Console.WriteLine("Enter Genres (0 to exit)");

		while (true)
		{
			string genre = Console.ReadLine()!;

			if (genre == "0")
			{
				break;
			}

			game.Genres.Add(genre);
		}

		try
		{
			_gameService.AddGame(game);
		}
		catch (DuplicateIdException ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void ShowGames()
	{
		var allGames = _gameService.GetAllGames();

		foreach (var game in allGames)
		{
			Console.WriteLine($"Game Id: {game.Id}");
			Console.WriteLine($"Game Name: {game.Name}");

			Console.WriteLine("Game Genres: ");

			foreach (var genre in game.Genres)
			{
				Console.WriteLine(genre);
			}
		}
	}

	public static void Run()
	{
		bool flag = true;
		
		while (flag)
		{
			Console.WriteLine("1. Add Game");
			Console.WriteLine("2. Show Games");
			Console.WriteLine("3. Exit");
			
			int choice = int.Parse(Console.ReadLine()!);

			switch (choice)
			{
				case 1:
					AddGame();
					break;
				case 2:
					ShowGames();
					break;
				case 3:
					flag = false;
					break;
			}
		}
	}
}