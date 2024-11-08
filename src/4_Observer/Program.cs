using Observer.Entities;
using Observer.Metrics;
using Observer.Models;
using Observer.Writers;

var chat = new Chat(1, "my_chat");
var user = new User(1, "user");

var writer = new ConsoleChatWriter();

chat.AddObserver(writer);

chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));
chat.SendMessage(new UserMessage(user, "hi!"));


static void WriteMetrics(long chatId, IEnumerable<IChatMetric> metrics)
{
    Console.WriteLine("Metrics: ");

    foreach (IChatMetric metric in metrics)
    {
        Console.WriteLine($"{metric.Name}: ");
        Console.WriteLine(metric.Format(chatId));
        Console.WriteLine();
    }
}