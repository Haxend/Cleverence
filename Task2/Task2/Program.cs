class Program
{
    private static async Task HandleAsync()
    {
        Console.WriteLine("Enter Handler");
        await Task.Delay(6000);
        Console.WriteLine("Exit Handler");
    }

    static async Task Main(string[] args)
    {
        Task task = HandleAsync();
        if (await Task.WhenAny(task, Task.Delay(5000)) == task)
            Console.WriteLine("Completed successfully");
        else
            Console.WriteLine("Timeout occured");
        Console.WriteLine("Done.");
        Console.ReadKey();
    }

}