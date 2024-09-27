using System.Diagnostics.CodeAnalysis;

namespace ProgrammingConstructsPart1;

public class NarrowingWideningDataTypeConversions
{
    public static void Main()
    {
        Console.WriteLine("***** Fun with type conversions *****");

        // Add two shorts and print the result.
        short numb1 = 9, numb2 = 10;
        Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

        // Compiler error below!
        /*
        short numb3 = 30000, numb4 = 30000;
        short answer = Add(numb3, numb4);

        Console.WriteLine("{0} + {1} = {2}", numb3, numb4, numb3 + numb4);
        */

        // Explicitly cast the int into a short (and allow loss of data).
        numb1 = 30000;
        numb2 = 30000;
        short answer = (short)Add(numb1, numb2);

        Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

        NarrowingAttempt();
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    // Another compiler error!
    static void NarrowingAttempt()
    {
        byte myByte = 0;
        int myInt = 200;
        // myByte = myInt;

        // Console.WriteLine("Value of myByte: {0}", myByte);

        // Explicitly cast the int into a byte (no loss of data).
        myByte = (byte)myInt;
        Console.WriteLine("Value of myByte: {0}", myByte);
    }

    public static void ProcessBytes()
    {
        byte b1 = 100;
        byte b2 = 250;
        // byte sum = (byte)Add(b1, b2);

        // sum should hold the value 350. However, we find the value 94;
        // Console.WriteLine("sum = {0}", sum);

        // This time, tell the compiler to add CIL code
        // to throw an exception if overflow/underflow
        // takes place.
        try
        {
            byte sum = checked((byte)Add(b1, b2));
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            checked
            {
                byte sum = (byte)Add(b1, b2);
                Console.WriteLine("sum = {0}", sum);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Using the unchecked Keyword
        unchecked
        {
            byte sum = (byte)(b1 + b2);
            Console.WriteLine("sum = {0}", sum);
        }
    }
}