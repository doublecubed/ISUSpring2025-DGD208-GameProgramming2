namespace ISUSpring2025_DGD208;

public class PlayerController
{
    private const int _numberEaten = 5;
    
    private AttackHandler _attackHandler;
    private FoodHandler _foodHandler;
    private PlayerDeath _playerDeath;   
    
    #region DELEGATES
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
    #endregion

    // Old way of declaring events.
    // Downsides: EventArgs have to be declared custom each time
    // I always have to send a sender, which is obviously the object itself.
    //public event EventHandler<AttackEventArgs> OnAttackHappened;

    public event Action<int> OnPlayerAttacked;

    public event Action<int, string> OnPlayerEatsFood;

    public event Action OnPlayerDeath;
    
    public PlayerController()
    {
        _attackHandler = new AttackHandler(this);
        _foodHandler = new FoodHandler(this);
        _playerDeath = new PlayerDeath(this);

        MessageDisplayer.Instance.StartingMessage();
    }
    
    public void Run()
    {
        PlayerAttacks();
        PlayerEatsFood();
        PlayerDies();
        PlayerDies();
    }

    private void PlayerAttacks()
    {
        int attackType = 56;
        OnPlayerAttacked?.Invoke(attackType);
        
        // Arguments for the old event that we used
        //AttackEventArgs attackArg = new AttackEventArgs(attackType);
        //OnAttackHappened?.Invoke(this, attackArg);
    }

    private void PlayerEatsFood()
    {
        string message = "You monster!";
        
        OnPlayerEatsFood?.Invoke(_numberEaten, message);
    }

    private void PlayerDies()
    {
        OnPlayerDeath?.Invoke();
    }
}

// Completely useless when I use Actions
public class AttackEventArgs : EventArgs
{
    public int AttackType { get; }

    public AttackEventArgs(int attackType)
    {
        AttackType = attackType;
    }
}