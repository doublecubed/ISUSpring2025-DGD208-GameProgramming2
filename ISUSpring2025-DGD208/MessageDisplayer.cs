namespace ISUSpring2025_DGD208;

public class MessageDisplayer
{
    public static MessageDisplayer Instance;

    public MessageDisplayer()
    {
        // We generally put a safeguard here
        // The instance destroys itself if there is an Instance already
        Instance = this;
    }

    public void StartingMessage()
    {
        Console.WriteLine("Let the games begin!");
    }

    public void DisplayMessage(string theMessage)
    {
        Console.WriteLine(theMessage);
    }
}

