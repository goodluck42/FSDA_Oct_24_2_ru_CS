namespace SOLID.Exceptions;

class DuplicateIdException : Exception
{
	public DuplicateIdException(string message) : base(message)
	{
	}
}