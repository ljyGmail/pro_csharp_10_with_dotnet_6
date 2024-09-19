namespace ProgrammingConstructsPart1;

public class EnvironmentMembers
{
    public static void ShowEnvironmentDetails()
    {
        // Print out the drives on the machine,
        // and other interesting details.
        foreach (string drive in Environment.GetLogicalDrives())
        {
            System.Console.WriteLine("Drive: {0}", drive);
        }

        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Core Version: {0}", Environment.Version);
        // Select properties of System.Environment
        Console.WriteLine("ExitCode: {0}", Environment.ExitCode);
        Console.WriteLine("Is64BitOperatingSystem: {0}", Environment.Is64BitOperatingSystem);
        Console.WriteLine("MachineName: {0}", Environment.MachineName);
        Console.WriteLine("NewLine: {0}", Environment.NewLine);
        Console.WriteLine("ProcessId: {0}", Environment.ProcessId);
        Console.WriteLine("ProcessPath: {0}", Environment.ProcessPath);
        Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);
        Console.WriteLine("UserName: {0}", Environment.UserName);
    }
}