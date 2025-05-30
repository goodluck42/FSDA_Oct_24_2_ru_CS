
Weapon[] weapons = new Weapon[3];

weapons[0] = new Shotgun();
weapons[1] = new Shotgun();
weapons[2] = new SniperRifle();

foreach (var weapon in weapons)
{
	weapon.Fire();
}

abstract class Weapon
{
	private string? _name;
	protected Weapon(string name)
	{
		_name = name;
	}

	public string GetName()
	{
		return _name;
	}
	public int Damage { get; set; }
	public abstract void Fire();
}

class Shotgun : Weapon
{
	public Shotgun() : base("Shotgun")
	{
		Damage = 10;
	}
	public override void Fire()
	{
		Console.WriteLine("Shotgun.Fire");
	}
}

class SniperRifle : Weapon
{
	public SniperRifle() : base("SniperRifle")
	{
		
	}

	public override void Fire()
	{
		Console.WriteLine("SniperRifle.Fire");
	}
}


