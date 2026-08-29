class Student : Person
{
    public int RollNo;    // Stores the roll number
    public String? Course;  // Stores the course
    public static int count=0;   // Starts the count
    public string? COURSE      // Property of course
    {
        // Retrieves the data from Course
        get
        {
            return Course;
        }

        // Inserts the data into the course
        set
        {
            if(string.Equals(value, "Computer Science", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
                System.Console.WriteLine("Course Stored");
            }
            else if(string.Equals(value, "Mechanical", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
                System.Console.WriteLine("Course Stored");
            }
            else if(string.Equals(value, "Civil", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
                System.Console.WriteLine("Course Stored");
            }
            else
            {
                System.Console.WriteLine("Course not Available, Please Choose a valid Course");
            }
            
        }
    }
    public int Marks;   // Stores the value of marks out of 100 

    public int MARKS    // Property of Marks
    {
        get
        {
            return Marks;
        }
        set
        {
            if(value >= 0 && value <= 100)
            {
                Marks = value;
                System.Console.WriteLine("Marks stored");
            }
            else
            {
                System.Console.WriteLine("Please Enter Marks above 0 and below 100...");
            }
            
        }
    }

}