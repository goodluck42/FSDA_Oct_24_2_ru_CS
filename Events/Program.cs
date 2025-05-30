// using System.Data;
// using Telegram.Bot;
// using Telegram.Bot.Types;
// using Telegram.Bot.Types.Enums;
//
// var apiKey = "7989625849:AAFTgLUZAVy1j5jd54zcsBjrr5eaCQ3niKg";
// var client = new TelegramBotClient(apiKey);
// var manualResetEvent = new ManualResetEvent(false);
//
// client.OnMessage += async (message, updateType) =>
// {
// 	if (updateType == UpdateType.Message)
// 	{
// 		var text = message.Text!;
// 		Console.WriteLine($"Text: {text}");
// 		var dataTable = new DataTable();
// 		var chatId = new ChatId(message.Chat.Id);
//
// 		try
// 		{
// 			var result = dataTable.Compute(text, null);
//
// 			await client.SendMessage(chatId, $"Result: {result}");
// 		}
// 		catch (Exception ex)
// 		{
// 			await client.SendMessage(chatId, ex.Message);
// 		}
// 	}
// };
//
// manualResetEvent.WaitOne();

///////////////////////////
using Events; 
var chat = new Chat();
var manualResetEvent = new ManualResetEvent(false);

chat.OnMessageSend += (message) =>
{
	Console.WriteLine($"{DateTime.Now.ToLongTimeString()}: {message}");
};

_ = Task.Run(async () =>
{
	while (true)
	{
		await Task.Delay(Random.Shared.Next(1, 5) * 100);
	
		chat.SendMessage(Guid.NewGuid().ToString());
	}
});

manualResetEvent.WaitOne();

// Action
// var del1 = (int value, float value2) => Console.WriteLine(value + value2);
// Action<int, float> del2 = (value, value2) => Console.WriteLine(value + value2);

// Func

// Func<string, string, int> del = (a, b) =>
// {
// 	int result = int.Parse(a + b);
// 	return result;
// };
//
// Func<int> func = () => 42;

// Predicate

// var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
// Predicate<int> evenPred = x => x % 2 == 0;
// // Func<int, bool> evenPred2 = x => x % 2 == 0;
//
// list.RemoveAll(evenPred);
//
// foreach (var value in list)
// {
// 	Console.WriteLine(value);
// }

// static class Functions
// {
// 	public static int MyMethod(string a, string b)
// 	{
// 		int result = int.Parse(a + b);
// 		return result;
// 	}
// }