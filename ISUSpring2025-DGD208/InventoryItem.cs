namespace ISUSpring2025_DGD208;

public class InventoryItem : ICommand
{
    public InventoryItem()
    {
        Name = "default";
        Description = "default";
    }
    
    public InventoryItem(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public string Name { get; private set; }
    public string Description { get; private set; }

    public void Use()
    {
        // Describe the use of the item
    }
}