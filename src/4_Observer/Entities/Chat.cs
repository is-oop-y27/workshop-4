using Observer.Models;

namespace Observer.Entities;

public class Chat
{
    public Chat(long id, string name)
    {
        Id = id;
        Name = name;
    }

    public long Id { get; }

    public string Name { get; }

    public void SendMessage(UserMessage message) { }
}