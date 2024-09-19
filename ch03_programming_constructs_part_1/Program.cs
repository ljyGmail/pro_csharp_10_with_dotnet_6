// See https://aka.ms/new-console-template for more information
using ProgrammingConstructsPart1;

Console.WriteLine("Chapter03 Core C# Programming Constructs, Part 1");

// Process any incoming args.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg[{0}]: {1}", i, args[i]);
}

// Notice you have no need to check the size of the array when using "foreach"
// Process any incoming args using foreach.
foreach (string arg in args)
{
    Console.WriteLine("Arg: {0}", arg);
}

// Get arguments using System.Environment
string[] theArgs = Environment.GetCommandLineArgs();
// The first entry holds the name of the application itself,
// while the remaining elements in the array contain the individual command-line arguments.
foreach (string arg in theArgs)
{
    Console.WriteLine("Arg: {0}", arg);
}

// # Additional Members of the System.Environment Class(Updated 10.0)
// EnvironmentMembers.ShowEnvironmentDetails();

// # Using the System.Console Class
// UsingConsoleClass.GetUserData();
// # Formatting Console Output
// UsingConsoleClass.FormattingConsoleOutput();
// # Formatting Numerical Data
// UsingConsoleClass.FormatNumericalData();
// # Formatting Numerical Data Beyond Console Applications
UsingConsoleClass.StringFormatDemo();

return 0;