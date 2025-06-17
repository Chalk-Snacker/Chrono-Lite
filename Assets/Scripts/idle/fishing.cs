public class Fishing_equipment
{
    // --- accessors ---
    public string Name { get; set; }
    public int Lvl_requirement { get; set; }
    public int Quality { get; set; }

    // public price{get;set;}

    // --- constructor ---
    public Fishing_equipment(string name, int lvl_requirement, int quality)
    {
        Name = name;
        Lvl_requirement = lvl_requirement;
        Quality = quality;
    }

    // --- initializations ---
    public static Fishing_equipment Flimsy_rod = new Fishing_equipment("Flimsy fishing rod", 1, 1);
    public static Fishing_equipment Flimsy_rod_2 = new Fishing_equipment(
        "Slightly less flimsy fishing rod",
        4,
        2
    );
}

// --- XP ---
public class Pond
{
    // add formula for xp_incrase to calc the xp increase determined from current skill lvl
    // --- accessors ---
    public string Name { get; set; }
    public int Lvl_requirement { get; set; }
    public int XP { get; set; }

    // --- constructor ---
    public Pond(string name, int lvl_requirement, int xp_increase)
    {
        Name = name;
        Lvl_requirement = lvl_requirement;
        XP = xp_increase;
    }

    // --- initializations ---
    public static Pond Backyard = new Pond("Backyard pond", 1, 2);
    public static Pond Small_lake = new Pond("Small lake", 8, 5);
}
