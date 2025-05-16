namespace NamespacesStructsEnumsNullables.Models
{
	class User
	{
		private int _id;

		public int Id
		{
			get
			{
				// var json = JsonSerializer.Serialize(this);

				// ... 
				return _id;
			}
			set => _id = value;
		}

		public string FirstName { get; set; }
	}
}

namespace NamespacesStructsEnumsNullables2
{
	class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
	}
}

