namespace ChoreScore.Models;
public class Chore
{
    public Chore(int id, string title, string category, string weekday, bool completed)
    {
        Id = id;
        Title = title;
        Category = category;
        Weekday = Weekday;
        Completed = completed;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public string Weekday { get; set; }
    public bool Completed { get; set; }
}