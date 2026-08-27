class Person
{
    public string? name;
    public int age;

    public int Age{
        get
        {
            return age;
        }
        set
        {
            if (age >= 0)
            {
                age = value;
            }
            else
            {
                System.Console.WriteLine("Please Enter a Valid Age");
            }
        }
    }
}