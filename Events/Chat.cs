namespace Events;

class Chat
{
	private readonly List<string> _messages;
	private event Action<string>? _onMessageSend;
	public Chat()
	{
		_messages = [];
	}

	public void SendMessage(string message)
	{
		if (string.IsNullOrWhiteSpace(message))
		{
			return;
		}

		message = message.Trim();
		
		_messages.Add(message);
		
		_onMessageSend?.Invoke(message);
	}

	public event Action<string>? OnMessageSend
	{
		add // subscribe
		{
			_onMessageSend += value;
			Console.WriteLine("Someone is subscribed to you.");
		}
		remove // unsubscribe
		{
			_onMessageSend -= value;
		}
	}

}