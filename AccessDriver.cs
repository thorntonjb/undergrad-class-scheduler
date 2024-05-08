// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(String[] args)
    {
        Access test = new Access();

        //int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Let's plan your undergraduate Computer Science degree out!");
        Console.WriteLine("Please choose an option below:");
        Console.WriteLine(@"   1. Add a class to your plan" + Environment.NewLine +
                            "   2. Remove a class from your plan" + Environment.NewLine +
                            "   3. Review your undergraduate plan" + Environment.NewLine +
                            "   4. Login as Admin" + Environment.NewLine +
                            "   x. Exit");


        Console.WriteLine(test);

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Hello There!");
                break;
            case 2:

                break;
            case 3:

                break;
            default:
                Console.WriteLine("Apologies, but you must enter a valid number.");
                break;
        }
    }

}
