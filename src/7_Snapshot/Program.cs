using Snapshot.Models;

var caretaker = new TextFieldHistory(new TextField());

caretaker.UpdateValue("1");
TextFieldSnapshot snapshot = caretaker.UpdateValue("2");

Console.WriteLine(string.Join("\n", caretaker.History.Select(x => x.ToString())));

Console.WriteLine(caretaker.Value);
caretaker.Restore(snapshot);
Console.WriteLine(caretaker.Value);