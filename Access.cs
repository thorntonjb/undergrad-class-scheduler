using System;
using System.Collections.Generic;
using System.IO;

public class Access
{
    private List<Courses> listOfGenEds = new List<Courses>();
    private List<Courses> listOfElectives = new List<Courses>();
    private UndergradView plan = new UndergradView();
    Courses defaultCourse = new Courses();

    public Access()
    {
        const char DELIMIT = ',';
        const string FILEPATH = "classes.csv";

        if (File.Exists(FILEPATH))
        {
            using (StreamReader reader = new StreamReader(FILEPATH))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(DELIMIT);

                    int classIDInInt = Convert.ToInt16(values[2]);
                    Courses course = new Courses(string.Join("",values[0]),
                                                    string.Join("",values[1]).ToUpper(),
                                                    classIDInInt,
                                                    string.Join("",values[3]));
                    determineArray(course);
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    } // end Access constructor

    public void determineArray(Courses _course)
    {
        if (_course.getClassType().Equals("gened"))
        {
            listOfGenEds.Add(_course);
        }
        else //(_course.getClassType().Equals("elective"))
        {
            listOfElectives.Add(_course);
        }
    } // end determineArray function

    public void userArrayChoice()
    {
        int choice = 0;
        //string YesOrNo;
        while (choice != 3 )
        {
            Console.WriteLine("What type of class? Choose one below:");
            Console.WriteLine(@"   1. General Education Class" + Environment.NewLine +
                                "   2. Elective Class" + Environment.NewLine +
                                "   3. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // gened
                    foreach (Courses course in listOfGenEds)
                    {
                        Console.WriteLine(course.ToString());
                    }

                    findGenEdForUser();
                    Console.WriteLine(Environment.NewLine + "Choose another class or exit!");

                    continue;
                case 2: // elective
                    foreach (Courses course in listOfElectives)
                    {
                        Console.WriteLine(course.ToString());
                    }

                    findElectiveForUser();
                    Console.WriteLine(Environment.NewLine + "Choose another class or exit!");

                    continue;
                case 3: // exit
                    Console.WriteLine("Bye bye!");
                    break;
                default: // QA-esque
                    Console.WriteLine("Please enter a valid response. Thank you.");
                    break;
            } // end switch
        } // end while
    }

    public Courses findGenEdForUser()
    {
        Console.WriteLine("Please write the class code (i.e. ITSC) and class ID (i.e. 1212) of the class you want!");
        string classChoice = Console.ReadLine();

        foreach (Courses element in listOfGenEds)
        {
            if ((element.getClassCode() + element.getClassID()) == classChoice)
            {
                Console.WriteLine("You chose " + element.getClassName() + "!");
                plan.getUserDesiredCourses().Add(element.getClassName());
                Console.WriteLine(plan.getUserDesiredCourses()[0]);
                return element;
            }
        }

        return defaultCourse;
    }

    public Courses findElectiveForUser()
    {
        Console.WriteLine("Please write the class code (i.e. ITSC) and class ID (i.e. 1212) of the class you want!");
        string classChoice = Console.ReadLine();

        foreach (Courses element in listOfElectives)
        {
            if ((element.getClassCode() + element.getClassID()) == classChoice)
            {
                Console.WriteLine("You chose " + element.getClassName() + "!");
                plan.getUserDesiredCourses().Add(element.getClassName());
                return element;
            }
        }

        return defaultCourse;
    }

    // Getters for each of the class Lists.
    public List<Courses> getGenEdsList()
    {
        return listOfGenEds;
    }

    public List<Courses> getElectivesList()
    {
        return listOfElectives;
    }

    public UndergradView getPlan()
    {
        return plan;
    }
} // end Access class
