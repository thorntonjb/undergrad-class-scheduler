using System.Collections.Generic;

public class UndergradView : Courses
{
    private List<String> userDesiredCourses;

    public UndergradView()
        : base()
    {
        userDesiredCourses = new List<String>();
    }

    public List<String> getUserDesiredCourses()
    {
        return userDesiredCourses;
    }

    public override string ToString()
    {
        return "";
    }
}
