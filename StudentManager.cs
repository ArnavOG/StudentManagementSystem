// This class Handles all of the Operations on Student's Data

class StudentManager : StudentServices
{
    // Method for Adding a Student
    public Boolean AddStudentSuccess = false;  // Checks if Student is added or not and returns the result
    public override Boolean AddStudent()
    {
        // Displays Add Student Interface
        System.Console.WriteLine("================================================================================");
        System.Console.WriteLine("                            ADD NEW STUDENT");
        System.Console.WriteLine("================================================================================\n \n");

        // Objects for Data from classes Person/Student
        Person person = new Person();
        Student student = new Student();

        System.Console.Write("Enter Name         :   ");  // Takes Name
        person.name = Console.ReadLine();
        
        System.Console.Write("Enter Age          :   ");  // Takes Age
        person.age = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Roll Number  :   ");  // Takes Roll Number
        student.RollNo = Convert.ToInt32(Console.ReadLine());

        
        System.Console.WriteLine("Courses: Java / C# / Python \n");
        System.Console.Write("Enter Course       :   ");  // Takes Course
        student.Course = Console.ReadLine();

        System.Console.Write("Enter Marks        :   ");  // Takes Marks
        student.Marks = Convert.ToInt32(Console.ReadLine());


        return AddStudentSuccess;
    }


    // Method for Viewing all Students
    public override void ViewAllStudents()
    {
        
    }


    // Method for Searching a student
    public Boolean StudentFound = false;  // Checks if the desired student was found or not
    public override Boolean SearchStudent()
    {


        return StudentFound;
    }


    // Method for Updating a student
    public Boolean UpdateSuccess = false;  // Checks if the data was updated successfully
    public override Boolean UpdateStudent()
    {
        

        return UpdateSuccess;
    }


    // Method for Deleting a student
    public Boolean DeleteSuccess = false;  // Checks if the deletion was successful
    public override Boolean DeleteStudent()
    {
        

        return DeleteSuccess;
    }
}