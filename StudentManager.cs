// This class Handles all of the Operations on Student's Data

class StudentManager
{
    // Method for Adding a Student
    public Boolean AddStudentSuccess = false;  // Checks if Student is added or not and returns the result
    public Boolean AddStudent()
    {


        return AddStudentSuccess;
    }


    // Method for Viewing all Students
    public void ViewAllStudents()
    {
        
    }


    // Method for Searching a student
    public Boolean StudentFound = false;  // Checks if the desired student was found or not
    public Boolean SearchStudent()
    {


        return StudentFound;
    }


    // Method for Updating a student
    public Boolean UpdateSuccess = false;  // Checks if the data was updated successfully
    public Boolean UpdateStudent()
    {
        

        return UpdateSuccess;
    }


    // Method for Deleting a student
    public Boolean DeleteSuccess = false;  // Checks if the deletion was successful
    public Boolean DeleteStudent()
    {
        

        return DeleteSuccess;
    }
}