using InterfaceÖvning.Classes;
using InterfaceÖvning.Interfaces;

var firstProgram = new Program1();
var secondProgram = new Program2();

// Original calls before introducing the interface:
// firstProgram.run();
// secondProgram.Go();

firstProgram.start();
secondProgram.start();
firstProgram.Describe();

var runner = new DualRunner();
((IVoidRunner)runner).run();
Console.WriteLine($"Returned value: {((IIntRunner)runner).run()}");

