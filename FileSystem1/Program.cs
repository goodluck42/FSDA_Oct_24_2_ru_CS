using System.Text;
using System.Text.Json;
using FileSystem1;

// var text = "Console.WriteLine(\"Hello World\");";
// using (FileStream stream = File.Create("file.cs"))
// {
// 	var bytes = Encoding.UTF8.GetBytes(text);
//
// 	stream.Write(bytes);
// } // ... Dispose & Flush
//
// Console.ReadLine();


//// Directory and Path classes
// var currentDirectory = Directory.GetCurrentDirectory();
//
// Console.WriteLine(currentDirectory);
//
// var result = Path.Combine("User", "Alex", "Desktop");
//
// Console.WriteLine(result);
//
// var ext = Path.GetExtension(@"C:\tile.txt"); // verbatim string
//
// Console.WriteLine(ext);


//// Streams
//// StreamReader & StreamWriter
//// #1
// using var fileStream = new FileStream("file.txt", FileMode.Append, FileAccess.Write);
// using var streamWriter = new StreamWriter(fileStream);

//// #2
// using var streamWriter = new StreamWriter("file.txt", true);
//
// streamWriter.WriteLine("123");

//// #3 StreamReader

// using var streamReader = new StreamReader("file.txt");

// while (true)
// {
// 	var line = streamReader.ReadLine();
//
// 	if (line == null)
// 	{
// 		break;
// 	}
//
// 	Console.WriteLine(line);
// }

// char[] buffer = new char[64];
//
// streamReader.ReadBlock(buffer, 0, 5);
// streamReader.ReadBlock(buffer, 0, 5);

// Console.WriteLine(buffer);
// Console.WriteLine(buffer.ToString());

// var stringBuilder = new StringBuilder();
//
// stringBuilder.Append(buffer);
//
// var resultStr = stringBuilder.ToString();
//
// Console.WriteLine(resultStr);


//// JSON Data Types
// {} - object
// [] - array
// 

//// JSON Write
// IRandomBookGenerator generator = new RandomBookGenerator();
// IEnumerable<Book> books = generator.Generate(10);
//
// var json = JsonSerializer.Serialize(books, new JsonSerializerOptions
// {
// 	WriteIndented = true
// });
//
// File.WriteAllText("books.json", json);

//// JSON Read

// var json = File.ReadAllText("books.json");
// var books = JsonSerializer.Deserialize<IEnumerable<Book>>(json);
//
// if (books != null)
// {
// 	foreach (var book in books)
// 	{
// 		Console.WriteLine(book.Id);
// 		Console.WriteLine(book.Title);
// 		Console.WriteLine();
// 	}
// }

//// var book = JsonSerializer.Deserialize<Book>("{\"Id\": 9,\"Title\": \"Title_1824560555\",\"Genre\": \"Psychology\",\"PublishDate\": \"2025-06-04T17:22:58.969361+04:00\",\"AuthorName\": \"Author_1570629368\"}");
//
// Console.WriteLine(book.Id);
// Console.WriteLine(book.Title);
// Console.WriteLine(book.Genre);