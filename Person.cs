class Person
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
}