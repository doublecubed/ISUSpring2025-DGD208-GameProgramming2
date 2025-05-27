namespace ISUSpring2025_DGD208;

public class CommandHandler
{
    
    public void Command<T>(T myArgument) where T : class, ICommand, new()
    {
        if (myArgument is Coordinate)
        {
            Coordinate coords = myArgument as Coordinate;
            Console.WriteLine($"I'm moving the player to {coords.X}, {coords.Y}");
            return;
        }

        if (myArgument is InventoryItem)
        {

            return;
        }
        
    }
    
    public void IssueMoveCommand(Coordinate coord)
    {
        // Call the player move class to move the player to a certain position
    }

    public void IssueInventoryItemCommand(InventoryItem item)
    {
        // Call the player inventory class to use the specified item
    }

    public void IssueAddCoinsCommand(int coins)
    {
        // Call the player resources class to add coins
    }
    
    
}