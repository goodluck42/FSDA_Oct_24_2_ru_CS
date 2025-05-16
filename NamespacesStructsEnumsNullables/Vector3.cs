namespace NamespacesStructsEnumsNullables;

struct Vector3
{
	public Vector3()
	{
		X = 0;
		Y = 0;
		Z = 0;
	}
	
	public float X { get; init; }
	public float Y { get; init; }
	public float Z { get; init; }
	
	public Vector3 Add(Vector3 vector)
	{
		Vector3 newVector = new Vector3
		{
			X = vector.X + X,
			Y = vector.Y + Y,
			Z = vector.Z + Z
		};
		
		return newVector;
	}
}