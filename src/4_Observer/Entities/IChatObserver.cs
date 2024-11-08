using Observer.Models;

namespace Observer.Entities;

public interface IChatObserver
{
    void OnChatMessageReceived(ChatUserMessage message);
}