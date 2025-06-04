namespace FileSystem1;

interface IRandomBookGenerator
{
	Book Generate();
	IEnumerable<Book> Generate(int count);
}