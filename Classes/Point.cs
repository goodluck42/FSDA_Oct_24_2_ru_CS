class Point
{
	public Point(int x, int y)
	{
		_x = x;
		_y = y;
	}
	
	private readonly int _x;
	private readonly int _y;

	public int X
	{
		get
		{
			return _x;
		}
	}

	public int Y
	{
		get
		{
			return _y;
		}
	}
}