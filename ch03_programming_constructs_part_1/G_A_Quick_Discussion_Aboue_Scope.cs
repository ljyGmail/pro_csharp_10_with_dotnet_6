namespace ProgrammingConstructsPart1;

public class AQuickDiscussionAboutScope
{
    public static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Number is: {0}", i);
        }

        // following code is exactly the same as above
        for (int i = 0; i < 4; i++)
            Console.WriteLine("Number is: {0}", i);

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Number is: {0}", i);
            Console.WriteLine("Number plus 1 is: {0}", i + 1);
        }

        for (int i = 0; i < 4; i++)
            Console.WriteLine("Number is: {0}", i);
        // Console.WriteLine("Number plus 1 is: {0}", i + 1); // compilation error
    }
}