using System.Collections.Generic;

public class UndergradView
{
    private string className;
    private List<String> userDesiredCourses;

    UndergradView(string _className)
    {
        className = _className;
        userDesiredCourses = new List<String>();
    }

    public List<String> getUserDesiredCourses()
    {
        return userDesiredCourses;
    }

    public string getClassName()
    {
        return className;
    }

    public void setClassName(string _className)
    {
        className = _className;
    }
}
