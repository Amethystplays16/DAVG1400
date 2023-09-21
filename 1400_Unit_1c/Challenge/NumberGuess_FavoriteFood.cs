public class NumberGuesser
{
    int SecrtaNumber = 0;
   public void SetSecrtaNumber()
    {
        System.Random rnd = new System.Random();        // Here is where we tell it to generat a random number
        SecrtaNumber = rnd.Next(1, 10);
    }

    public void PrentSecrtaNumber()
    {
        System.Console.WriteLine(SecrtaNumber);
    }

    public void GuessSecrtaNumber()
    { 
    System.Console.WriteLine("I now have a Secret, which I would like you to guess.");      //Here we are promting the user to guess the number
        int GuessCount = 0;        
        int Guess = 0;
        while (SecrtaNumber != Guess)               // her is were the while loop so the user can guess as many times as need
        {
            System.Console.WriteLine("Please enter a number between 1 and 10? ");
            string MyGuess = System.Console.ReadLine();
            int.TryParse(MyGuess, out Guess);
            if (Guess < SecrtaNumber)                       // This is a if, else statment to help the user 
            {
                System.Console.WriteLine("Guess Higher.");
                    GuessCount++;
                continue;
            }
            else if (Guess > SecrtaNumber)
            {
                System.Console.WriteLine("Guess Lower.");
                    GuessCount++;
                continue;
            }
            else
            {
                 GuessCount++;
            }
        }

        System.Console.WriteLine("You guessed the number! ");                   // And then here is where it congaaltes the user
        System.Console.WriteLine("It took you " + GuessCount + " tries. ");

        System.Console.WriteLine();
    }

}       

public class FavoriteFoods
{
    string[] Position = { "first", "second", "third" };            // Here we have writen a string to add in a word as it gose
    string[] FoodStorage;

    public void GetFavFood()
    {
        FoodStorage = new string[3];            // This is where we will store the info the user enters
        for (int i = 0; i < FoodStorage.Length; i++)                // And here is the For Loop to ask the user again
        {
            System.Console.WriteLine("Please enter your " + Position[i] + " Favorite Food? ");      //Now it will ask the user to enter the Favorite Foodwss
            FoodStorage[i] = System.Console.ReadLine();
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        for (int i = 0;i < FoodStorage.Length; i++)
        {
            System.Console.WriteLine("Your " + Position[i] + " favorite food is " + FoodStorage[i] + "! ");         //Here it will print out the users Favorite Food
        }
    }


}


public class Program            //This is so we can actully use the progam
{
    public static void Main()
    {
        NumberGuesser ng = new NumberGuesser();
        ng.SetSecrtaNumber();
        ng.GuessSecrtaNumber();     

        FavoriteFoods FF = new FavoriteFoods();
        FF.GetFavFood();
    }

}