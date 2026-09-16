class Student
{
    public string? name;   // Stores the Name of a person
    public int age;   // Stores the Age of a person
    public Boolean AgeCheck = false;

    public int Age{       // Property of Age

        //retrieves the age value
        get
        {
            return age;
        }

        // Writes into the value of age
        set
        {
            if (value >= 0)
            {
                age = value;
                System.Console.WriteLine("-----> Age stored");
                AgeCheck = false;
            }
            else
            {
                System.Console.WriteLine("-----> Please Enter a Valid Age...");
                AgeCheck = true;
            }
            
        }
    }
    public int RollNo;    // Stores the roll number
    public String? Course;  // Stores the course
    public Boolean CourseCheck = false;
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
                System.Console.WriteLine("-----> Course Stored");
                CourseCheck = false;
            }
            else if(string.Equals(value, "Mechanical", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
                System.Console.WriteLine("-----> Course Stored");
                CourseCheck = false;
            }
            else if(string.Equals(value, "Civil", StringComparison.OrdinalIgnoreCase))
            {
                Course = value;
                System.Console.WriteLine("-----> Course Stored");
                CourseCheck = false;
            }
            else
            {
                System.Console.WriteLine("-----> Course not Available, Please Choose a valid Course");
                CourseCheck = true;
            }
            
        }
    }
    public int Marks;   // Stores the value of marks out of 100 
    public Boolean MarksCheck = false;

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
                System.Console.WriteLine("-----> Marks stored");
                MarksCheck = false;
            }
            else
            {
                System.Console.WriteLine("-----> Please Enter Marks above 0 and below 100...");
                MarksCheck = true;
            }
            
        }
    }

}