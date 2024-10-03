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
// Console.WriteLine("***** Fun with Basic Data Types *****");
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
// WorkWithSystemDataTypesAndKeywords.BinaryLiterals();

// # Working with String Data
// Console.WriteLine("***** Working with String Data *****");

// ## Performing Basic String Manipulation
// WorkingWithStringData.BasicStringFunctionality();

// ## Performing String Concatenation
// WorkingWithStringData.StringConcatenation();

// ## Using Escape Characters
// WorkingWithStringData.EscapeChars();

// ## Performing String Interpolation
// WorkingWithStringData.StringInterpolation();

// ### Performance Improvements (Updated 10.0)
// WorkingWithStringData.StringInterpolationWithDefaultInterpolatedStringHandler();

// ## Defining Verbatim Strings (Updated 8.0)
// WorkingWithStringData.VerbatimStrings();

// ## Working with Strings and Equality
// WorkingWithStringData.StringEquality();

// ### Modifying String Comparison Behavior
// WorkingWithStringData.StringEqualitySpecifyingCompareRules();

// ## Strings Are Immutable
// WorkingWithStringData.StringsAreImmutable();
// WorkingWithStringData.StringsAreImmutable2();

// ## Using the System.Text.StringBuilder Type
// WorkingWithStringData.FunWithStringBuilder();

// # Narrowing and Widening Data Type Conversions
// NarrowingWideningDataTypeConversions.Main();

// ## Using the checked Keyword
// NarrowingWideningDataTypeConversions.ProcessBytes();

// # Working with C# Iteration Constructs
// ## Using the for Loop
// WorkingWithCSharpIterationConstructs.UsingForLoop();

// ## Using the foreach Loop
// WorkingWithCSharpIterationConstructs.ForEachLoopExample();

// ## Using Implicit Typing Within foreach Constructs
// WorkingWithCSharpIterationConstructs.LinqQueryOverInts();

// ## Using the while and do/while Looping Constructs
// WorkingWithCSharpIterationConstructs.WhileLoopExample();
// WorkingWithCSharpIterationConstructs.DoWhileLoopExample();

// # A Quick Discussion About Scope
// AQuickDiscussionAboutScope.Main();

// # Working with Decision Constructs and the Relational / Equality Operators
// ## Using the if/else statement
// ## Using Equality and Relational Operators
WorkingWithDecisionConstructsRelationalEqualityOperators.IfElseExample();

// ## Using if/else with Pattern Matching (New 7.0)
WorkingWithDecisionConstructsRelationalEqualityOperators.IfElsePatternMatching();

// ## Making Pattern Matching Improvements (New 9.0)
WorkingWithDecisionConstructsRelationalEqualityOperators.IfElsePatternMatchingUpdatedInCSharp9();

// ## Using the Conditional Operator (Updated 7.2, 9.0)
WorkingWithDecisionConstructsRelationalEqualityOperators.ExecuteIfElseUsingConditionalOperator();
WorkingWithDecisionConstructsRelationalEqualityOperators.ConditionalRefExample();

// ## Using Logical Operators

// ## Using the switch Statement
// WorkingWithDecisionConstructsRelationalEqualityOperators.SwitchExample();
// WorkingWithDecisionConstructsRelationalEqualityOperators.SwitchOnStringExample();
// WorkingWithDecisionConstructsRelationalEqualityOperators.SwitchOnEnumExample();
// WorkingWithDecisionConstructsRelationalEqualityOperators.SwitchWithGoto();

// ## Performing switch Statement Pattern Matching (New 7.0, Updated 9.0)
// WorkingWithDecisionConstructsRelationalEqualityOperators.ExecutePatternMatchingSwitch();
// WorkingWithDecisionConstructsRelationalEqualityOperators.ExecutePatternMatchingSwitchWithWhen();

// ## Using switch Expressions (New 8.0)
string color = WorkingWithDecisionConstructsRelationalEqualityOperators.FromRainbowClassic("Blue");
Console.WriteLine(color);
color = WorkingWithDecisionConstructsRelationalEqualityOperators.FromRainbow("Violet");
Console.WriteLine(color);

string result = WorkingWithDecisionConstructsRelationalEqualityOperators.RockPaperScissors("paper", "rock");
Console.WriteLine(result);
result = WorkingWithDecisionConstructsRelationalEqualityOperators.RockPaperScissors("scissors", "scissors");
Console.WriteLine(result);

return 0;