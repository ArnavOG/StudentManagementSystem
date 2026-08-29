// This class Handles all of the Operations on Student's Data

class StudentManager : StudentServices
{
   
    // Method for Adding a Student
    public Boolean AddStudentSuccess = false;  // Checks if Student is added or not and returns the result
    public override Boolean AddStudent()
    {

        AddStudentSuccess = false;

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
        person.Age = Convert.ToInt32(Console.ReadLine());


        System.Console.Write("Enter Roll Number  :   ");  // Takes Roll Number
        student.RollNo = Convert.ToInt32(Console.ReadLine());

        
        System.Console.WriteLine("Courses: Computer Science / Mechanical / Civil \n");
        System.Console.Write("Enter Course       :   ");  // Takes Course
        student.COURSE = Console.ReadLine();


        System.Console.Write("Enter Marks        :   ");  // Takes Marks
        student.MARKS = Convert.ToInt32(Console.ReadLine());

         
     // Add student object into the List
        // student.Add(student);                // Jisne bhi ye likha hai wo dubara ek baar check kar le 🙂

        AddStudentSuccess = true;

        return AddStudentSuccess;
    }


    // Method for Viewing all Students
    public override void ViewAllStudents()
    { 
    //     try
    //    {
    //        if (Student.count == 0) // Check how many students are in the list
    //          {
    //              // Check if the list is empty
    //              System.Console.WriteLine("\nNo Student Found.\n");

    //              return;
    //           }

    //         System.Console.WriteLine("\n================================================================================");
    //         System.Console.WriteLine("                            ALL STUDENTS");
    //         System.Console.WriteLine("================================================================================");

    // // Access each student using the foreach loop
    // foreach (Student student in student)
    // {
    //     // Display student details
    //     System.Console.WriteLine("\nName       : " + student.name);
    //     System.Console.WriteLine("Age          : " + student.age);
    //     System.Console.WriteLine("Roll Number  : " + student.RollNo);
    //     System.Console.WriteLine("Course       : " + student.Course);
    //     System.Console.WriteLine("Marks        : " + student.Marks);

    //         System.Console.WriteLine("--------------------------------------------------------------------------------");
    //         }
    //    }
    //         catch (NullReferenceException)
    //         {
    //             System.Console.WriteLine("\nError: Student data is not available.\n");
    //         }
    //         catch (Exception ex)
    //         {
    //             System.Console.WriteLine("\nAn error occurred while viewing students.");
    //             System.Console.WriteLine("Error: " + ex.Message);
    //         }
    }


    // Method for Searching a student
    public Boolean StudentFound = false;  // Checks if the desired student was found or not
    public override Boolean SearchStudent()
    {
     // Take the roll number as input
    System.Console.Write("Enter Roll Number to Search :   ");
    int rollNo = Convert.ToInt32(Console.ReadLine());

    // Check each student one by one in the list
    foreach (Student student in students)
    {
        // Check whether the roll number matches or not
        if (student.RollNo == rollNo)
        {
            // Student found
            StudentFound = true;

            // Display the student's details
            System.Console.WriteLine("\n===== STUDENT FOUND =====");

            System.Console.WriteLine("Name         : " + student.name);
            System.Console.WriteLine("Age          : " + student.age);
            System.Console.WriteLine("Roll Number  : " + student.RollNo);
            System.Console.WriteLine("Course       : " + student.Course);
            System.Console.WriteLine("Marks        : " + student.Marks);

            // The student was found, so return from here
            return StudentFound;
        }
    }

    // If the student is not found after checking the entire list
    System.Console.WriteLine("\nStudent Not Found.");

    StudentFound = false;

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