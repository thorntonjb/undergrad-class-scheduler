public class UndergradView
{
    private string className;
    private int numOfSemesters;

    UndergradView(string _className)
    {
        className = _className;
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
