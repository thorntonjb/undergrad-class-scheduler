using System;
using System.Collections.Generic;
using System.IO;

public class Access
{
    private List<Courses> listOfGenEds = new List<Courses>();
    private List<Courses> listOfCapstones = new List<Courses>();
    private List<Courses> listOfElectives = new List<Courses>();

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

                    foreach (string value in values)
                    {
                        int classIDInInt = Convert.ToInt16(values[2]);
                        Courses course = new Courses(string.Join("",values[0]),
                                                     string.Join("",values[1]),
                                                     classIDInInt,
                                                     string.Join("",values[3]));
                        determineArray(course);
                    }

                    // Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public void determineArray(Courses _course)
    {
        if (_course.getClassType().Equals("gened"))
        {
            listOfGenEds.Add(_course);
        }
        else if (_course.getClassType().Equals("capstone"))
        {
            listOfCapstones.Add(_course);
        }
        else //(_course.getClassType().Equals("elective"))
        {
            listOfElectives.Add(_course);
        }
    }


}
