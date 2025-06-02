using System.Collections;

int iterations = 10_000_000;

// ArrayList
{
	var now = DateTime.Now;
	var arr = new ArrayList();

	for (int i = 0; i < iterations; i++)
	{
		arr.Add(Random.Shared.Next().ToString()); // boxing
	}

	for (int i = 0; i < iterations; i++)
	{
		string value = (string)arr[i]; // unbox
	}
	
	var end = DateTime.Now;

	Console.WriteLine($"ArrayList: {(end - now).TotalMilliseconds}");
}

{
	
	var now = DateTime.Now;
	var arr = new List<int>();

	for (int i = 0; i < iterations; i++)
	{
		arr.Add(Random.Shared.Next()); // boxing
	}

	for (int i = 0; i < iterations; i++)
	{
		int value = arr[i]; // unbox
	}
	
	var end = DateTime.Now;

	Console.WriteLine($"List<T>: {(end - now).TotalMilliseconds}");
}

//////////////////////////
// ArrayList list = new ArrayList();
//
// list.Add(10); // boxing
// list.Add(20); // boxing
// list.Add(30); // boxing
//
// for (int i = 0; i < list.Count; i++)
// {
// 	int value = (int)list[i]; // unboxing => heap -> stack
//
// 	Console.WriteLine(value * 2);
// }

///////////////////

// int a = 42;
//
// BoxMe(a);
//
// // boxing => stack -> heap
// void BoxMe(object value)
// {
// 	
// }

// IRepository<FileItem> repository = new Repository<FileItem>();
//
// var file = repository.CreateFile("file.txt");
//
// interface IRepository<T>
// 	where T : RepositoryItem, new()
// {
// 	T CreateFile(string name);
// }
//
// class Repository<T> : IRepository<T>
// 	where T : RepositoryItem, new()
// {
// 	public T CreateFile(string name)
// 	{
// 		T file = new T()
// 		{
// 			Name = name,
// 		};
// 		
// 		return file;
// 	}
// }
//
// abstract class RepositoryItem
// {
// 	public string? Name { get; init; }
// 	public abstract bool IsFolder { get; }
// }
//
// class FolderItem : RepositoryItem
// {
// 	public string? Path { get; init; }
// 	public override bool IsFolder => true;
// }
//
// class FileItem : RepositoryItem
// {
// 	public string? Extension => Path.GetExtension(Name);
// 	public override bool IsFolder => false;
// }