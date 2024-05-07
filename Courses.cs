public class Courses
{
    private string classType;
    private string classCode;
    private int classID;
    private string className;

    public Courses(string _classType, string _classCode, int _classID, string _className)
    {
        classType = _classType;
        classCode = _classCode;
        classID = _classID;
        className = _className;
    }

    public string getClassType()
    {
        return classType;
    }

    public string getClassCode()
    {
        return classCode;
    }

    public int getClassID()
    {
        return classID;
    }

    public string getClassName()
    {
        return className;
    }

    public void setType(string _classType)
    {
        classType = _classType;
    }

    public void setClassCode(string _classCode)
    {
        classCode = _classCode;
    }

    public void setClassID(int _classID)
    {
        classID = _classID;
    }

    public void setClassName(string _className)
    {
        className = _className;
    }



}
