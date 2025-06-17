public class Cooking_equipment
{
    // --- accessors ---
    public string Name { get; set; }
    public int Lvl_requirement { get; set; }
    public int Quality { get; set; }

    // public price{get;set;}

    // --- constructor ---
    public Cooking_equipment(string name, int lvl_requirement, int quality)
    {
        Name = name;
        Lvl_requirement = lvl_requirement;
        Quality = quality;
    }

    // --- initializations ---
    //public static Tool Flimsy_rod = new Tool("Flimsy fishing rod", 1, 1);
    // public static Tool Flimsy_rod_2 = new Tool("Slightly less flimsy fishing rod",4,2)
}

// --- XP ---
public class Cooking_recipe
{
    // calculate xp increase determined from quality of items used
    // --- accessors ---
    public string Name { get; set; }
    public int Lvl_requirement { get; set; }
    public int XP { get; set; }

    // --- constructor ---
    public Cooking_recipe(string name, int lvl_requirement, int xp_increase)
    {
        Name = name;
        Lvl_requirement = lvl_requirement;
        XP = xp_increase;
    }

    // --- initializations ---
    //public static Pond Backyard = new Pond("Backyard pond", 1, 2);
    //public static Pond Small_lake = new Pond("Small lake", 8, 5);
}
