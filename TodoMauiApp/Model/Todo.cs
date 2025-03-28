namespace TodoMauiApp.Model;

public class Todo {
    private Todo() { } // EF needs a constructor
    public Todo(string title, DateTime due, bool finished)
    {
        Title = title;
        Due = due;
        Finished = finished;
    }

    public int Id { get; private set; } // EF: key, auto inkrement
    
    public string Title { get; set; } = string.Empty;
    public DateTime Due { get; set; }
    public bool Finished { get; set; }
}
