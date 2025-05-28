using SOLID.Models;

namespace SOLID.Services;

interface IGameService
{
	void AddGame(Game game);
	void RemoveGame(int gameId);

	void RemoveGame(Game game)
	{
		RemoveGame(game.Id);
	}

	Game this[int id] { get; }

	List<Game> GetAllGames();
}