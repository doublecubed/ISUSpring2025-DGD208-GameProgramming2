namespace ISUSpring2025_DGD208;

public class PlayerCommander
{
    private CommandHandler _handler;

    
    public PlayerCommander()
    {
        _handler = new  CommandHandler();
    }

    public void Run()
    {
        _handler.Command(new Coordinate(5f,6f));
        _handler.Command<InventoryItem>(new InventoryItem("dagger", "stabby stab stab"));
    }
    
}