namespace ISUSpring2025_DGD208;

public class InventoryItem : ICommand
{
    // YOU THINK YOU ARE AN INVENTORY ITEM? MY DOG IS A BETTER INVENTORY ITEM THAN YOU.
    
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