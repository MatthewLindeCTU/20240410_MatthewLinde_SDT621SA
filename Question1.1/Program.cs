namespace Question1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "Blank";

            Console.WriteLine($"Hello {name}!");

            Console.WriteLine("\nProgram Structure Demonstated: ");

            Console.WriteLine("1. using System : imports functionality\n" +
                "2. namespace : organizes code\n" +
                "3. class Program : container for code\n" +
                "4. Main() : entry point of program\n" +
                "5. Comments : explain logic and documentation");

            Console.WriteLine("\nProgram executed successfully!");
        }
    }
}
