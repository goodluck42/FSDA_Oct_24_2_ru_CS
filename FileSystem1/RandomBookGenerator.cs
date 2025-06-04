namespace FileSystem1;

class RandomBookGenerator : IRandomBookGenerator
{
	private int _id;

	private static string[] _genres = ["Fantasy", "Action", "Melodrama", "Psychology", "Horror", "Detective", "Drama"];

	public RandomBookGenerator()
	{
		_id = 1;
	}
	
	public Book Generate()
	{
		var book = new Book
		{
			Id = _id++,
			Genre = _genres[Random.Shared.Next(0, _genres.Length)],
			AuthorName = $"Author_{Random.Shared.Next()}",
			PublishDate = DateTime.Now,
			Title = $"Title_{Random.Shared.Next()}",
		};

		return book;
	}

	public IEnumerable<Book> Generate(int count)
	{
		var books = new List<Book>();
		
		for (int i = 0; i < count; i++)
		{
			books.Add(Generate());
		}

		return books;
	}
}