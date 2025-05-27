namespace ISUSpring2025_DGD208;

public class Program
{
    static async Task Main(string[] args) 
    {
        new MessageDisplayer();
        
        PlayerController player = new PlayerController();
        player.Run();
        
        //DatabaseOps databaseOp = new DatabaseOps();
        //databaseOp.Run();
        
        //PlayerCommander commander = new PlayerCommander();
        //commander.Run();
        
        //AsyncOps ops = new AsyncOps(0);
        //await ops.Run();
        Console.WriteLine("program ends");
        
        // THE END
    }
}
