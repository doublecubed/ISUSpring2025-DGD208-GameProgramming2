namespace ISUSpring2025_DGD208;

public class FoodHandler
{

    public int EatBread(string name)
    {
        Console.WriteLine("Eating bread");
        return 0;
    }

    public int EatPie(string name)
    {
        Console.WriteLine("Eating pie");
        return 1;
    }

    public int EatShorts(string name)
    {
        Console.WriteLine("Mmm, shorts!");
        return 2;
    }
}

// Eat return integer legend
// 0 ate and no longer hungry
// 1 ate and still hungry
// 2 poisoned
// 3 felt cute, might eat later