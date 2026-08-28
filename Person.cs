class Person
{
    public string? name;   // Stores the Name of a person
    public int age;   // Stores the Age of a person

    public int Age{       // Property of Age

        //retrieves the age value
        get
        {
            return age;
        }

        // Writes into the value of age
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