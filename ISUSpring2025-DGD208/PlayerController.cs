namespace ISUSpring2025_DGD208;

public class PlayerController
{
    private AttackHandler _attackHandler;
    private FoodHandler _foodHandler;

    //public delegate void PlayerAttack(int i);
    //private PlayerAttack _playerAttack;
    public Action<int> _attack;

    //public delegate int EatFood(string n);
    //private EatFood _playerEatFood;
    public Func<string, int> _eatFood;

    // This func is exactly the same as the predicate below it
    public Func<int, bool> _myBoolFunc;
    
    // Takes only one input (any type) and returns a bool
    public Predicate<int> _myPredicate;
    
    public PlayerController()
    {
        _attackHandler = new AttackHandler();
        _foodHandler = new FoodHandler();

        _attack = _attackHandler.AttackWithFist;
        _attack += _attackHandler.AttackWithGun;
        
        _eatFood = _foodHandler.EatBread;
    }
    
    public void Run()
    {
        PlayerAttacks();
        PlayerEatsFood();
    }

    private void PlayerAttacks()
    {
        _attack?.Invoke(0);
    }

    private void PlayerEatsFood()
    {
        _eatFood("hey you");
    }
}