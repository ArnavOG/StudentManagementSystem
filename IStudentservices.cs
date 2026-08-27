interface IStudentservice
{
    bool AddStudent(Student student);

    void ViewAllStudents();

    Student? SearchStudent(int rollNo);

    bool UpdateStudent(
        int rollNo,
        string name,
        int age,
        string course,
        int marks);

    bool DeleteStudent(int rollNo);
}