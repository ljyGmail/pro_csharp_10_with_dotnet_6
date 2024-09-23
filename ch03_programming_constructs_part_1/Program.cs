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
// UsingConsoleClass.StringFormatDemo();

// # Working with System Data Types and Corresponding C# Keywords
// ## Understanding Variable Declaration and Initialization
Console.WriteLine("***** Fun with Basic Data Types *****");
// WorkWithSystemDataTypesAndKeywords.LocalVarDeclarations();

// ### The default Literal (New 7.1)
// WorkWithSystemDataTypesAndKeywords.DefaultDeclarations();

// ## Using Intrinsic Data Types and the new Operator (Updated 9.0)
// WorkWithSystemDataTypesAndKeywords.NewingDataTypes();
// WorkWithSystemDataTypesAndKeywords.NewingDataTypesWith9();

// ## Understanding the Data Type Class Hierarchy
// WorkWithSystemDataTypesAndKeywords.ObjectFunctionality();

// ## Understanding the Members of Numerical Data Types
// WorkWithSystemDataTypesAndKeywords.DataTypeFunctionality();

// ## Understanding the Members of System.Boolean
// WorkWithSystemDataTypesAndKeywords.BooleanProperties();

// ## Understanding the Members of System.Char
// WorkWithSystemDataTypesAndKeywords.CharFunctionality();

// ## Parsing Values from String Data
// WorkWithSystemDataTypesAndKeywords.ParseFromStrings();

// ## Using TryParse to Parse Values from String Data
// WorkWithSystemDataTypesAndKeywords.ParseFromStringsWithTryParse();

// ## Using System.DateTime and System.TimeSpan (Updated 10.0)
// WorkWithSystemDataTypesAndKeywords.UseDatesAndTimes();

// ## Working with the System.Numerics Namespace
// WorkWithSystemDataTypesAndKeywords.UseBigInteger();

// ## Using Digit Separators (New 7.0)
// WorkWithSystemDataTypesAndKeywords.DigitSeparators();

// ## Using Binary Literals (New 7.0/7.2)
WorkWithSystemDataTypesAndKeywords.BinaryLiterals();


return 0;