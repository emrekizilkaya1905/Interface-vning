using InterfaceÖvning.Interfaces;

namespace InterfaceÖvning.Classes;

public class Program2 : IStart
{
    // Original method, replaced by the shared interface contract:
    // public void Go()
    // {
    //     Console.WriteLine("nu kör vi program 2");
    // }

    public void start()
    {
        Console.WriteLine("nu kör vi program 2");
    }
}


