using Observer.Entities;

namespace Observer.Models;

public record ChatUserMessage(Chat Chat, UserMessage Message);