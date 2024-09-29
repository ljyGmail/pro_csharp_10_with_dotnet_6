namespace ProgrammingConstructsPart1;

public class WorkingWithCSharpIterationConstructs
{
    //    A basic for loop.
    public static void UsingForLoop()
    {
        Console.WriteLine("==> Using the for Loop:");
        // Note! "i" is only visible within the scope of the for loop.
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Number is: {0}", i);
        }
        // "i" is not visible here.
    }

    // Iterator array items using foreach.
    public static void ForEachLoopExample()
    {
        Console.WriteLine("=> Using the foreach Loop:");

        string[] catTypes = { "Ford", "BMW", "Yugo", "Honda" };
        foreach (string c in catTypes)
        {
            Console.WriteLine(c);
        }

        int[] myInts = { 10, 20, 30, 40 };
        foreach (int i in myInts)
        {
            Console.WriteLine(i);
        }
    }

    public static void LinqQueryOverInts()
    {
        Console.WriteLine("=> Using Implicit Typing Within foreach Constructs:");

        int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

        // LINQ query!
        var subset = from i in numbers where i < 10 select i;
        Console.WriteLine("Values in subset:");

        foreach (var i in subset)
        {
            Console.Write("{0} ", i);
        }
    }

    public static void WhileLoopExample()
    {
        Console.WriteLine("=> Using the while and do/while Looping Constructs:");

        string userIsDone = "";

        // Test on a lower-class copy of the string.
        while (userIsDone.ToLower() != "yes")
        {
            Console.WriteLine("In while loop");
            Console.Write("Are you done? [yes] [no]: ");
            userIsDone = Console.ReadLine();
        }
    }

    public static void DoWhileLoopExample()
    {
        string userIsDone = "";

        do
        {
            Console.WriteLine("In do/while loop");
            Console.WriteLine("Are you done? [yes] [no]: ");
            userIsDone = Console.ReadLine();

        } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
    }
}