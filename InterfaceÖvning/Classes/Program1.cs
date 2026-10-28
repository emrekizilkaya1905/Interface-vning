using InterfaceÖvning.Interfaces;

namespace InterfaceÖvning.Classes;

public class Program1 : IStart, IDescribe
{
    // Original method, replaced by the shared interface contract:
    // public void run()
    // {
    //     Console.WriteLine("Nu kör vi program 1");
    // }

    public void start()
    {
        Console.WriteLine("Nu kör vi program 1");
    }

    public void Describe()
    {
        Console.WriteLine("Program 1 implements both IStart and IDescribe.");
    }
}


