namespace ProgrammingConstructsPart1;

public class UsingConsoleClass
{
    // Performing Basic Input and Output(I/O) with the Console Class
    public static void GetUserData()
    {
        Console.Beep();
        // Get name and age.
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.Write("Please enter your age: ");
        string userAge = Console.ReadLine();

        // Change echo color, just for fun
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;

        // Echo to the console.
        Console.WriteLine("Hello {0}! Your are {1} years old.", userName, userAge);

        // Restore previous color.
        Console.ForegroundColor = prevColor;
    }

    // Formatting Console Output
    public static void FormattingConsoleOutput()
    {
        // John says...
        Console.WriteLine("{0}, Number {0}, Number {0}", 9);
        // Print: 20, 10, 30
        Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
    }

    // Now make use of some format tags.
    public static void FormatNumericalData()
    {
        Console.WriteLine("The value 99999 in various format:");
        Console.WriteLine("c format: {0:c}", 99999);
        Console.WriteLine("d9 format: {0:d9}", 99999);
        Console.WriteLine("f3 format: {0:f3}", 99999);
        Console.WriteLine("n format: {0:n}", 99999);

        // Notice that upper- or lowercasing for hex
        // determines if letters are upper- or lowercase.
        Console.WriteLine("E format: {0:E}", 99999);
        Console.WriteLine("e format: {0:e}", 99999);
        Console.WriteLine("X format: {0:X}", 99999);
        Console.WriteLine("x format: {0:x}", 99999);
    }

    public static void StringFormatDemo()
    {
        // Using string.Format() to format a string literal.
        string userMessage = string.Format("1000000 in hex is {0:x}", 1000000);
        Console.WriteLine(userMessage);
    }
}