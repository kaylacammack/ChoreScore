namespace ChoreScore.Services;
public class ChoreService
{
    private readonly ChoreRepository _repo;
    public ChoreService(ChoreRepository repo)
    {
        _repo = repo;
    }

    internal Chore Create(Chore choreData)
    {
        Chore newChore = _repo.Create(choreData);
        return newChore;
    }

    internal List<Chore> Get()
    {
        List<Chore> chores = _repo.Get();
        return chores;
    }

    internal string Remove(int id)
    {
        string message = _repo.Remove(id);
        return message;
    }
}