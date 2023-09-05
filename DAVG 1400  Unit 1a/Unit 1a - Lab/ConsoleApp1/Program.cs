internal class Program
{
    private static void Main(string[] args)
    {
        // First, let's work with the string type ...
        //
        string FirstName = "Mortimer";                  // Initialize the FirstName variable.
        string LastName = "Snerd";                      // Initializw the LastName variable.
        string FullName = FirstName + " " + LastName;   // Build the FullName from the FirstName and LastName variables.
        System.Console.WriteLine("Name: " + FullName);
        // https://www.youtube.com/watch?v=k6ZiNOi-xug

        // Time to use a bitwise operator
        string UppercaseLastName = "";
        for (int i = 0; i < LastName.Length; i++)
        {
            char ch = (char)(LastName[i] & 223);  // Turn off bit 5 for this character, make it uppercase.
            UppercaseLastName += ch;
        }
        System.Console.WriteLine("UppercaseLastName is " + UppercaseLastName);

        // Let's figure out his age
        int YearBorn = 1938, YearDied = 1978;
        int Age = YearDied - YearBorn;          // Finding his age is his death minus his birth.
        System.Console.WriteLine("Age: " + Age);
        if (Age >= 18)
            System.Console.WriteLine(FirstName + " Is an Adult");
        else
            System.Console.WriteLine(FirstName + " Is a Child");

        // Logic to see if he is Loved
        bool HasMother = true;
        bool HasGrandfather = true;
        bool HasGirlfriend = false;
        bool HasBeenKissedAsChild = true;
        bool HasBeenKissedAsAdult = false;
        bool HasFamily = HasMother || HasGrandfather;               // Family can be either a mother or a grandfather or both.
        bool HasRomance = HasGirlfriend && HasBeenKissedAsAdult;    // Rmmance is having a girlfriend AND she has kissed you.
        bool HasHomeLife = HasBeenKissedAsChild && HasFamily;       // HomeLife is love and care from your family AND having a family. 
        bool HasLove = HasHomeLife || HasRomance;                   // Has love could have happend at home OR with your girlfriend.
        System.Console.Write("Does " + FirstName + " know what love is? ");
        if (HasLove)
            System.Console.WriteLine("YES!");
        else
            System.Console.WriteLine("No.");

        // Let's see how happy he is? Items range from 1 to 100. List 6 life circumstances.
        float MeetAFriend = 45.0F;
        float GotInTrouble = -20.00F;
        float WentToSchool = 15.00F;
        float AteLunch = 35.00F;
        float DidChores = -15.00F;
        float PlayHideAndSike = 60.00F;

        float AtGrandmasHouse = 2.0F;                       // Grandma is a multiplier, because being at grandma's house makes everything extra special.

        float Monday = WentToSchool + AteLunch + DidChores;
        float Tuesday = WentToSchool + MeetAFriend + AteLunch;
        float Wednesday = WentToSchool + GotInTrouble + AteLunch;
        float Thursday = WentToSchool + AteLunch;
        float Friday = (WentToSchool + MeetAFriend + AteLunch) * AtGrandmasHouse;   // We were at grandma's house!

        System.Console.WriteLine("On Monday how happy was I? " + Monday + " out of 100");
        System.Console.WriteLine("On Tuesday how happy was I? " + Tuesday + " out of 100");
        System.Console.WriteLine("On Wednesday how happy was I? " + Wednesday + " out of 100");
        System.Console.WriteLine("On Thursday how happy was I? " + Thursday + " out of 100");
        System.Console.WriteLine("On Friday how happy was I? " + Friday + " out of 100");

        float AverageHappiness = (Monday + Tuesday + Wednesday + Thursday + Friday) / 5;    // To get our average happiness, we sum the happiness for each day and divide by the number of days.

        System.Console.WriteLine("Average happiness for the week is " + AverageHappiness + " out of 100");
    }
}