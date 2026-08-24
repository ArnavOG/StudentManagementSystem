using System;

class Menu
{
    public void main_screen()
    {
        
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine("                   STUDENT MANAGEMENT SYSTEM ");
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        System.Console.WriteLine("\n1. Add Student \n2. View All students \n3. Search Student \n4. Delete Student  \n5. Update Student \n6. Exit");
        System.Console.WriteLine("\n");
        System.Console.WriteLine("Enter your option");
        int Choic;
        Choic=Convert.ToInt32(Console.ReadLine());
    }
}


class Program
{
    static void Main(string[] args)
    {    
        Menu m=new Menu();
        Console.WriteLine("hello");
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=" );
        m.main_screen();
    }
}
