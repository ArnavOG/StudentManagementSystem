class Student : Person
{
    public int RollNo;
    public String? Course;
public static int count=0;
    public string? COURSE
    {
        get
        {
            return Course;
        }

        set
        {
            if(string.Equals(Course, "Computer Science", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
            }
            else if(string.Equals(Course, "Mechanical", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
            }
            else if(string.Equals(Course, "Computer Science", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
            }
            else
            {
                System.Console.WriteLine("Course not Available, Please Choose a valid Course");
            }
        }
    }
    public int Marks;
}