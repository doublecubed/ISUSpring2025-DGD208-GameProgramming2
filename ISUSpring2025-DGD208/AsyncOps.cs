namespace ISUSpring2025_DGD208;

public class AsyncOps
{
    private int _numberOfTasks;
    
    public AsyncOps(int taskNo)
    {
        _numberOfTasks = taskNo;
    }

    public async Task Run()
    {
        new MessageDisplayer();
        
        MessageDisplayer.Instance.StartingMessage();
        
        Console.WriteLine("Connecting server... Counting chickens");
        
        List<Task> tasks = new List<Task>();
        tasks.Add(ReceiveDataFromServer());
        tasks.Add(CountingTheChickens());
        
        
        
        Console.WriteLine("Program continues, we are not waiting for the tasks");
    }

    private async Task ReceiveDataFromServer()
    {
        await Task.Delay(500);
        Console.WriteLine("Connection established. Waiting for data...");
        await Task.Delay(3000); // We imagine it takes three seconds to return the data
        Console.WriteLine("Data received from server");
    }

    private async Task CountingTheChickens()
    {   
        for (int i = 0; i < 5; i++)
        {
            await Task.Delay(200);
            Console.WriteLine($"Counting chicken {i + 1}");
            await Task.Delay(1000);
        }
        
        Console.WriteLine("All chickens counted");
    }
}