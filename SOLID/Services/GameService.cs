using SOLID.Exceptions;
using SOLID.Models;

namespace SOLID.Services;

class GameService : IGameService
{
	private readonly List<Game> _games;

	public GameService()
	{
		_games = [];
	}

	public void AddGame(Game game)
	{
		for (int i = 0; i < _games.Count; i++)
		{
			if (_games[i].Id == game.Id)
			{
				throw new DuplicateIdException("Game with such id already exists.");
			}
		}

		_games.Add(game);
	}

	public void RemoveGame(int gameId)
	{
		foreach (var game in _games)
		{
			if (game.Id == gameId)
			{
				_games.Remove(game);
				break;
			}
		}
	}

	public Game this[int id]
	{
		get => _games.First(x => x.Id == id);
	}

	public List<Game> GetAllGames() => _games;
	
}