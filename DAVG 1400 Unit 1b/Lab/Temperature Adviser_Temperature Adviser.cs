using System.Runtime.CompilerServices;

public class Grader
{
    public void Checkgrade()
    {
        int Score = -1;
       
        while (Score <0 || Score >100)          // This is a "If" staitment that lops until we get a corent number and is with in the peramiters we set
        {
            System.Console.Write("Enter your current Score? ");
            string MyScore = System.Console.ReadLine();
            
            if (!int.TryParse(MyScore, out Score))
            {
                System.Console.WriteLine(" ---> Error: that is not a valid number!");
                System.Console.WriteLine();
                continue;
            }

            if (Score < 0)
            {
                System.Console.WriteLine(" ---> Error: the Score cannot be less than 0!");
                System.Console.WriteLine();
                continue;
            }
            else if (Score > 100)
            {
                System.Console.WriteLine(" ---> Error: the Score cannot be more than 100!");
                System.Console.WriteLine();
                continue;
            }

         
        }

        if (Score >= 90)                                        // This is a "if, else" to determen what grade we got
            System.Console.WriteLine("You have an A! ");
        else if (Score >= 80)
            System.Console.WriteLine("You have an B! ");
        else if (Score >= 70)
            System.Console.WriteLine("You have an C! ");
        else if (Score >= 60)
            System.Console.WriteLine("You have an D! ");
        else
            System.Console.WriteLine("You have an F!");
    }


}

public class Weather
{
    public void CheckTem()
    {
        int degrees = -1;

        while (degrees < 0 || degrees > 100)        // This is a "If" staitment that lops until we get a corent number and is with in the peramiters we set
        {
            System.Console.Write("Enter the current Temperature (In Celsius)? ");
            string MyTemp = System.Console.ReadLine();

            if (!int.TryParse(MyTemp, out degrees))
            {
                System.Console.WriteLine(" ---> Error: that is not a valid number!");
                System.Console.WriteLine();
                continue;
            }

            if (degrees < -273)
            {
                System.Console.WriteLine(" ---> Error: the Temperature cannot be less than -273!");
                System.Console.WriteLine();
                continue;
            }
            else if (degrees > 100)
            {
                System.Console.WriteLine(" ---> Error: the Temperature cannot be more than 100!");
                System.Console.WriteLine();
                continue;
            }


        }

        /*
         *   Create a program that asks the user to enter the current temperature in Celsius. Use an "if" statement to check
         *   if the temperature exceeds 30 degrees Celsius. If it is, display a message suggesting the user stay hydrated and avoid staying in the sun for too long.
         *   If the temperature is below 30 degrees Celsius, display a message suggesting the user enjoys the pleasant weather.
         *   
         *   It specifies for above 30 and for below 30 but nothing for being equal to 30, so we get to be snarky.
         */


        if (degrees > 30)                                        // This is a "if, else" to determen if it is good weather outside.
            System.Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
        else if (degrees == 30)                                        
            System.Console.WriteLine("They didn't tell me what you should do, so you are on your own!");
        else
            System.Console.WriteLine("Enjoy the pleasant weather.");
    }

}

internal class Program
{
    private static void Main(string[] args)         // without Main we cannt run our progam
    {
        Grader EnterGrades = new Grader();
        EnterGrades.Checkgrade();

        Weather CheckWeather = new Weather();
        CheckWeather.CheckTem();
    }

}