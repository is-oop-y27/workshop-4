using Observer.Entities;
using Observer.Models;

namespace Observer.Writers;

public class ConsoleChatWriter : IChatObserver
{
    public void OnChatMessageReceived(ChatUserMessage message)
    {
        var text = $"""
        [{message.Chat.Name}] {message.Message.User.Username}: {message.Message.Message}
        """;

        Console.WriteLine(text);
    }
}