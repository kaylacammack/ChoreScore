namespace ChoreScore.Repositories;
public class ChoreRepository
{
    private List<Chore> choreDb;
    public ChoreRepository()
    {
        this.choreDb = new List<Chore>(){
            new Chore(1, "Change Sheets", "Bedroom", "Monday", false ),
            new Chore(2, "Dust Furniture", "Bedroom", "Monday", false),
            new Chore(3, "Declutter", "Bedroom", "Monday", false),
            new Chore(4, "Tidy Closets", "Bedroom", "Monday", false),
            new Chore(5, "Vacuum & Mop", "Bedroom", "Monday", false),
            new Chore(6, "Wipe Mirrors", "Bathroom", "Tuesday", false),
            new Chore(7, "Clean Toilet & Bath", "Bathroom", "Tuesday", false),
            new Chore(8, "Vacuum & Mop", "Bathroom", "Tuesday", false),
            new Chore(9, "Stock Toilet Paper", "Bathroom", "Tuesday", false),
            new Chore(10, "Replace Towels", "Bathroom", "Tuesday", false),
            new Chore(11, "Change Rugs", "Entrance", "Wednesday", false),
            new Chore(12, "Sort Shoes/Coats", "Entrance", "Wednesday", false),
            new Chore(13, "Disinfect Doorknobs", "Entrance", "Wednesday", false),
            new Chore(14, "Wipe Surface", "Entrance", "Wednesday", false),
            new Chore(15, "Clean Window", "Entrance", "Wednesday", false),
            new Chore(16, "Clean out Fridge", "Grocery", "Thursday", false),
            new Chore(17, "Clear Expired Items", "Grocery", "Thursday", false),
            new Chore(18, "Organize Pantry", "Grocery", "Thursday", false),
            new Chore(19, "Grocery Shopping", "Grocery", "Thursday", false),
            new Chore(20, "Clean Window", "Grocery", "Thursday", false),
            new Chore(21, "Vacuum Car", "Misc", "Friday", false),
            new Chore(22, "Clean Blinds", "Misc", "Friday", false),
            new Chore(23, "Clear Hallways", "Misc", "Friday", false),
            new Chore(24, "Clean Tv Unit", "Living Area", "Saturday", false),
            new Chore(25, "Dust Furniture", "Living Area", "Saturday", false),
            new Chore(26, "Declutter", "Living Area", "Saturday", false),
            new Chore(27, "Vacuum & Mop", "Living Area", "Saturday", false),
            new Chore(28, "Clean Sink & Stovetop","Kitchen", "Sunday", false),
            new Chore(29, "Clean Kitchen Table", "Kitchen", "Sunday", false),
            new Chore(30, "Wipe Appliance", "Kitchen", "Sunday", false),
            new Chore(31, "Wipe Fridge", "Kitchen", "Sunday", false),
            new Chore(32, "Sweep & Mop", "Kitchen", "Sunday", false),

        };
    }
    internal Chore Create(Chore choreData)
    {
        choreData.Id = choreDb[choreDb.Count - 1].Id + 1;
        choreDb.Add(choreData);
        return choreData;
    }

    internal List<Chore> Get()
    {
        return choreDb;
    }

    internal string Remove(int id)
    {
        Chore choreToRemove = choreDb.Find(c => c.Id == id);
        bool result = choreDb.Remove(choreToRemove);
        if (result)
        {
            return $"{choreToRemove.Title} was removed from db";
        }
        return "No chore to delete";
    }
}