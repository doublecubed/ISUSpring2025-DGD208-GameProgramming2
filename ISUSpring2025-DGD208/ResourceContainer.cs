namespace ISUSpring2025_DGD208;

public class ResourceContainer<T>
{
    public ResourceContainer(T resource, int startingAmount = 0)
    {
        Resource = resource;
        Count = startingAmount;
    }
    
    public T Resource {get; private set;}
    public int Count {get; private set;}
    
    
    public void AddResource(int amount)
    {
        Count += amount;
    }
}