using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class MyProgram
{
    private static void Main(string[] args)
    {
        AnotherFunction();
    }

    private static void AnotherFunction()
    {
        int myInt = 5;

        MyProgram CanRun = new MyProgram();

        CanRun.CLassUnit01bChallenge();
    }

    public void CLassUnit01bChallenge()
   
    {   // First, let's work with the string type ...
        string FirstName = "Sandy";                  // Initialize the FirstName variable.
        string LastName = "Break";                      // Initializw the LastName variable.
        string FullName = FirstName + " " + LastName;   // Build the FullName from the FirstName and LastName variables.
        System.Console.WriteLine("Name: " + FullName);
        

            // Let's figure out how many year Sandy has traveled 
        int StarDay = 1997, EndDay = 2012;
        int Time = EndDay - StarDay ;          // Finding his age is his death minus his birth.
            System.Console.WriteLine("Years Travelling " + Time);
       

        // Logic to see if Sandy can go shoping?
            bool OpenMonday = true;
            bool OpenTuesday = true;
            bool OpenWednesday = false;
            bool OpenThursday = true;
            bool OpenFriday = false;
            bool OpenSaturday = true;
            bool OpenSunday = false;
            bool CanShop = OpenMonday && OpenTuesday && OpenThursday && OpenSaturday;
            bool CantShop = OpenWednesday && OpenFriday && OpenSunday;
            System.Console.Write("Can " + FirstName + " go shoping on Thursday ? ");
                if (CanShop)
                    System.Console.WriteLine("YES!");
                else
                    System.Console.WriteLine("No.");
                //Let's pick Sandy Favorite Coler
                    Console.Write("What is Sandys Favorite Color? ");
                    string Favcoler = Console.ReadLine();

        //How much did it cost for Sandy to traveling 15 years
        Console.Write("How much dose it cost to travel for 1 year? ");
            string YearlyCost  = Console.ReadLine();
        int Ycost;
        int.TryParse(YearlyCost, out Ycost);
            int YearTaveling = 15;
        int MoneySpent = Ycost * YearTaveling;
        System.Console.WriteLine("How much money did it cost to travel for 15 years " + MoneySpent);

    }


}