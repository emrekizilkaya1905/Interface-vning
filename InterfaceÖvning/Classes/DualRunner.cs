using InterfaceÖvning.Interfaces;

namespace InterfaceÖvning.Classes;

public class DualRunner : IVoidRunner, IIntRunner
{
    // C# cannot overload methods by return type alone.
    // Explicit interface implementations let both contracts coexist.
    void IVoidRunner.run()
    {
        Console.WriteLine("Running IVoidRunner.run() with return type void.");
    }

    int IIntRunner.run()
    {
        Console.WriteLine("Running IIntRunner.run() with return type int.");
        return 7;
    }
}

