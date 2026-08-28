using System;
using System.Collections.Generic;


// This class Handles all of the Operations on Student's Data

class StudentManager : StudentServices
{
    // List is used to store all student records
    private List<Student> students = new List<Student>();


    // ============================================================
    // METHOD FOR ADDING A STUDENT
    // ============================================================

    public Boolean AddStudentSuccess = false;
    // Checks if Student is added or not and returns the result

    public override Boolean AddStudent()
    {
        // Displays Add Student Interface
        System.Console.WriteLine("================================================================================");
        System.Console.WriteLine("                            ADD NEW STUDENT");
        System.Console.WriteLine("================================================================================\n\n");

        // Create a new Student object
        Student student = new Student();

        // Takes Name
        System.Console.Write("Enter Name         :   ");
        student.name = Console.ReadLine();

        // Takes Age
        System.Console.Write("Enter Age          :   ");
        student.age = Convert.ToInt32(Console.ReadLine());

        // Takes Roll Number
        System.Console.Write("Enter Roll Number  :   ");
        student.RollNo = Convert.ToInt32(Console.ReadLine());

        // Display available courses
        System.Console.WriteLine("Courses: Java / C# / Python\n");

        // Takes Course
        System.Console.Write("Enter Course       :   ");
        student.Course = Console.ReadLine();

        // Takes Marks
        System.Console.Write("Enter Marks        :   ");
        student.Marks = Convert.ToInt32(Console.ReadLine());


        // Add student object into the List
        students.Add(student);

        // Student has been added successfully
        AddStudentSuccess = true;

        // Return the result
        return AddStudentSuccess;
    }


    // ============================================================
    // METHOD FOR VIEWING ALL STUDENTS
    // ============================================================

    // Method for Viewing all Students
    public override void ViewAllStudents()
    {
        // Check whether the List contains any student or not
        if (students.Count == 0)
        {
            // If List is empty
            System.Console.WriteLine("\nNo Student Found.\n");

            return;
        }


        // Display heading
        System.Console.WriteLine("\n================================================================================");
        System.Console.WriteLine("                            ALL STUDENTS");
        System.Console.WriteLine("================================================================================");


        // foreach loop is used to access every student
        foreach (Student student in students)
        {
            // Display Student Details
            System.Console.WriteLine("\nName         : " + student.name);
            System.Console.WriteLine("Age          : " + student.age);
            System.Console.WriteLine("Roll Number  : " + student.RollNo);
            System.Console.WriteLine("Course       : " + student.Course);
            System.Console.WriteLine("Marks        : " + student.Marks);

            System.Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }


    // ============================================================
    // METHOD FOR SEARCHING A STUDENT
    // ============================================================

    public Boolean StudentFound = false;
    // Checks if the desired student was found or not

    public override Boolean SearchStudent()
    {
        // Ask the user for Roll Number
        System.Console.Write("\nEnter Roll Number to Search :   ");

        int rollNo = Convert.ToInt32(Console.ReadLine());


        // Search the student using Roll Number
        foreach (Student student in students)
        {
            // Check if entered Roll Number matches
            if (student.RollNo == rollNo)
            {
                // Student found
                StudentFound = true;


                // Display Student Details
                System.Console.WriteLine("\n================================================================================");
                System.Console.WriteLine("                            STUDENT FOUND");
                System.Console.WriteLine("================================================================================");

                System.Console.WriteLine("Name         : " + student.name);
                System.Console.WriteLine("Age          : " + student.age);
                System.Console.WriteLine("Roll Number  : " + student.RollNo);
                System.Console.WriteLine("Course       : " + student.Course);
                System.Console.WriteLine("Marks        : " + student.Marks);

                return StudentFound;
            }
        }


        // If Roll Number does not match with any student
        System.Console.WriteLine("\nStudent Not Found.");

        StudentFound = false;

        return StudentFound;
    }


    // ============================================================
    // METHOD FOR UPDATING A STUDENT
    // ============================================================

    public Boolean UpdateSuccess = false;
    // Checks if the data was updated successfully

    public override Boolean UpdateStudent()
    {
        // Ask user for Roll Number
        System.Console.Write("\nEnter Roll Number to Update :   ");

        int rollNo = Convert.ToInt32(Console.ReadLine());


        // Search student using Roll Number
        foreach (Student student in students)
        {
            // Check whether Roll Number exists
            if (student.RollNo == rollNo)
            {
                System.Console.WriteLine("\n===== ENTER NEW DETAILS =====");


                // Update Name
                System.Console.Write("Enter New Name    :   ");
                student.name = Console.ReadLine();


                // Update Age
                System.Console.Write("Enter New Age     :   ");
                student.age = Convert.ToInt32(Console.ReadLine());


                // Roll Number is NOT changed
                // because it is used to identify the student


                // Update Course
                System.Console.WriteLine("Courses: Java / C# / Python");
                System.Console.Write("Enter New Course  :   ");
                student.Course = Console.ReadLine();


                // Update Marks
                System.Console.Write("Enter New Marks   :   ");
                student.Marks = Convert.ToInt32(Console.ReadLine());


                // Data updated successfully
                UpdateSuccess = true;

                System.Console.WriteLine("\nStudent Updated Successfully.");

                return UpdateSuccess;
            }
        }


        // If student was not found
        System.Console.WriteLine("\nStudent Not Found.");

        UpdateSuccess = false;

        return UpdateSuccess;
    }


    // ============================================================
    // METHOD FOR DELETING A STUDENT
    // ============================================================

    public Boolean DeleteSuccess = false;
    // Checks if the deletion was successful

    public override Boolean DeleteStudent()
    {
        // Ask user for Roll Number
        System.Console.Write("\nEnter Roll Number to Delete :   ");

        int rollNo = Convert.ToInt32(Console.ReadLine());


        // Search student using Roll Number
        foreach (Student student in students)
        {
            // Check whether Roll Number matches
            if (student.RollNo == rollNo)
            {
                // Remove student from List
                students.Remove(student);

                // Deletion successful
                DeleteSuccess = true;

                System.Console.WriteLine("\nStudent Deleted Successfully.");

                return DeleteSuccess;
            }
        }


        // Student not found
        System.Console.WriteLine("\nStudent Not Found.");

        DeleteSuccess = false;

        return DeleteSuccess;
    }
}