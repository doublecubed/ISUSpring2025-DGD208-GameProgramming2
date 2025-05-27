namespace ISUSpring2025_DGD208;

public class AttackHandler
{
    private PlayerController _controller;
    
    public AttackHandler(PlayerController controller)
    {
        _controller = controller;
        _controller.OnPlayerAttacked += Attack;
        
        MessageDisplayer.Instance.DisplayMessage("Player attacks");
    }
    
    
    public void AttackWithFist()
    {
        Console.WriteLine("Player attacks with fists");
    }

    public void AttackWithSword()
    {
        Console.WriteLine("Player attacks with a sword");
    }

    public void AttackWithGun()
    {
        Console.WriteLine("Player attacks with a gun");
    }

    private void Attack(int attackType)
    {
        switch (attackType)
        {
            case 1: AttackWithSword();
                break;
            case 2: AttackWithGun();
                break;
            default: AttackWithFist();
                break;
        }
    }
    
}
