using System.Collections.Generic;

public class AccessDriver
{
    public static void Main(String[] args)
    {
        Access access = new Access();
        Courses courseBasejump = new Courses();
        UndergradView accessUserCourses = new UndergradView();

        List<Courses> userCourses = new List<Courses>();

        Console.WriteLine("Let's plan your undergraduate Computer Science degree out!");

        int choice = 0;
        try
        {
            while (choice != 3) {
                Console.WriteLine("Please choose an option below:");
                Console.WriteLine(@"   1. Add a class to your plan" + Environment.NewLine +
                                    "   2. Review your undergraduate plan" + Environment.NewLine +
                                    "   3. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        access.userArrayChoice();
                        break;
                    case 2:
                        int increment = 1;
                        foreach(string course in access.getPlan().getUserDesiredCourses())
                        {
                            Console.WriteLine(increment + ": " + course);
                            increment++;
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Apologies, but you must enter a valid number.");
                        break;
                } // end switch
            } // end while
        } // end try
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid Input. Try again.");
        }


    } // end main

} // end AccessDriver
