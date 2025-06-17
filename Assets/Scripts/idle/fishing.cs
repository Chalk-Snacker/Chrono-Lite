public class xp_threshold { }

public class Tool
{
    // --- accessors ---
    public string Name { get; set; }
    public int Lvl_requirement { get; set; }
    public int Quality { get; set; }

    // public price{get;set;}

    // --- constructor ---
    public Tool(string name, int lvl_requirement, int quality)
    {
        Name = name;
        Lvl_requirement = lvl_requirement;
        Quality = quality;
    }

    // --- initializations ---
    public static Tool Flimsy_rod = new Tool("Flimsy fishing rod", 1, 1);
}
