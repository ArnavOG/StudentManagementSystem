using System;


class Menu
{  
    public void main_screen()
    {    

       // START SCREEN 

       System.Console.Clear();
       System.Console.WriteLine("________________________________________________________________________________________________________");
       System.Console.WriteLine("\n");
       System.Console.WriteLine("===================================================================");
        
        System.Console.WriteLine("             WELCOME TO COLLEGE MANAGEMENT SYSTEM               ");

        System.Console.WriteLine("===================================================================");

        System.Console.WriteLine();

        System.Console.WriteLine("\n");

    
        System.Console.WriteLine("                  PLEASE ENTER TO CONTINUE.........              ");
       
        System.Console.WriteLine("\n");
        System.Console.WriteLine("                          👉   [ ENTER ]   👈                         ");

        System.Console.WriteLine("\n");
        System.Console.WriteLine("_________________________________________________________________________________________________________");
        System.Console.WriteLine("\n");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        

        System.Console.Clear();


        // MAIN MENU
        
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        System.Console.WriteLine("                              [ MAIN MENU ]                              ");
        System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        System.Console.WriteLine("\n1. Add Student \n2. View All students \n3. Search Student \n4. Delete Student  \n5. Update Student \n6. Exit");
        System.Console.WriteLine("\n");
       
        
        // check valid choice

        string choice;

        while(true){
         System.Console.Write("Enter your choice :");

         choice = Console.ReadLine() ??"";

         System.Console.WriteLine("\n");

        if (choice =="1"|| choice == "2" || choice =="3"|| choice =="4"|| choice =="5"|| choice =="6")
        {
            break;
        }
        
            System.Console.WriteLine("❌ Invalid choice!");
            
            System.Console.WriteLine("Please Enter a number between 1 and 6:");
        }
        
            switch(choice)
            {
            case "1" :
                System.Console.WriteLine("Add student ");
             break;

             case "2":
                System.Console.WriteLine("View Students");
            break;

            case "3": 
                System.Console.WriteLine( "Search Student ");
            break;

            case "4": 
                System.Console.WriteLine( "Search Student ");
            break;
            
              case "5": 
                System.Console.WriteLine( "Search Student ");
            break;

              case "6": 
                System.Console.WriteLine( "Search Student ");
            break;
     
            }
        }
    }



class Program
{
    static void Main(string[] args)

    {
        // Menu mu =new Menu();

        // mu.main_screen();

        StudentManager sm = new StudentManager();
        sm.AddStudent();
    }
} 
