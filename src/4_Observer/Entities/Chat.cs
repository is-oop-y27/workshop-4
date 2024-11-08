using Observer.Models;

namespace Observer.Entities;

public class Chat
{
    private readonly List<IChatObserver> _observers = [];

    public Chat(long id, string name)
    {
        Id = id;
        Name = name;
    }

    public long Id { get; }

    public string Name { get; }

    public void SendMessage(UserMessage message)
    {
        foreach (IChatObserver observer in _observers)
        {
            observer.OnChatMessageReceived(new ChatUserMessage(
                this,
                message));
        }
    }

    public void AddObserver(IChatObserver observer)
    {
        _observers.Add(observer);
    }
}