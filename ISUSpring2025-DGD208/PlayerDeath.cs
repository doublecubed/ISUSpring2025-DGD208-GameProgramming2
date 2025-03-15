namespace ISUSpring2025_DGD208;

public class PlayerDeath
{
    private PlayerController _controller;

    public PlayerDeath(PlayerController controller)
    {
        _controller = controller;
        _controller.OnPlayerDeath += Kill;
    }

    public void Kill()
    {
        Console.WriteLine("Player is dead. Long live the new player");
        _controller.OnPlayerDeath -= Kill;
    }
}