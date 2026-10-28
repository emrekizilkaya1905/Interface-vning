# Exercise 8 - Interfaces

The original `run()` and `Go()` methods and their calls are preserved as comments in Program.cs.

## Why use an interface?

IStart gives both classes a common contract: each must provide start(). Calling code can work with IStart without knowing which concrete class it receives. For example, Main stores both objects in one IStart array and starts them with the same loop. Additional classes can implement IStart and use the same calling code.

program1 also implements IDescribe and supplies Describe(), satisfying both interface contracts.

## Extra exercise

C# does not allow two ordinary methods to differ only by their return type. DualRunner therefore uses explicit interface implementations: IVoidRunner.run() returns void, while IIntRunner.run() returns 7. Main creates one DualRunner object and calls each implementation through its corresponding interface reference. Each implementation prints which method is running.

Class and method names from the assignment are retained, including program1, program2, start(), and run().

## Run

From the solution folder:

```powershell
dotnet run --project .\InterfaceÖvning\InterfaceÖvning.csproj
```
