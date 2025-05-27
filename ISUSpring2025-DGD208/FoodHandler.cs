namespace ISUSpring2025_DGD208;

public class FoodHandler
{
    private PlayerController _controller;

    public FoodHandler(PlayerController controller)
    {
        _controller = controller;
        _controller.OnPlayerEatsFood += (a, b) => Console.WriteLine($"You eat {a*a}, {b}");
        _controller.OnPlayerEatsFood += PlayerEatsFood;
    }

    private void PlayerEatsFood(int a, string b)
    {
        MessageDisplayer.Instance.DisplayMessage($"You eat {a*a}, {b}");
    }

    private void UnnecessaryThirdMethod(int a, string b)
    {
        Console.WriteLine($"You eat {a*a}, {b}");
    }
}

