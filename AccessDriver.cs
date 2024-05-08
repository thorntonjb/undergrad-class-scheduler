using System.Collections.Generic;

public class AccessDriver
{
    public static void Main(String[] args)
    {
        Access undergraduateView = new Access();
        Courses courseBasejump = new Courses();

        List<Courses> userCourses = new List<Courses>();

        Console.WriteLine("Let's plan your undergraduate Computer Science degree out!");
        Console.WriteLine("Please choose an option below:");
        Console.WriteLine(@"   1. Add a class to your plan" + Environment.NewLine +
                            "   2. Review your undergraduate plan" + Environment.NewLine +
                            "   3. Exit");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                undergraduateView.userArrayChoice();
                break;
            case 2:

                break;
            default:
                Console.WriteLine("Apologies, but you must enter a valid number.");
                break;
        }

    }

}
