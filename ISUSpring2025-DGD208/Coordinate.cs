namespace ISUSpring2025_DGD208;

public class Coordinate : ICommand
{
    // YOU THINK YOU CAN COORDINATE? MY DOG COORDINATES BETTER THAN YOU!
    
    public Coordinate()
    {
        X = 0;
        Y = 0;
    }
    
    public Coordinate(float x, float y)
    {
        X = x;
        Y = y;
    }
    
    public float X;
    public float Y;
}