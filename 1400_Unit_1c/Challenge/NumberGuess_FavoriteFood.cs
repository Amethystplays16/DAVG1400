public class NumberGuesser
{
    int SecrtaNumber = 0;
   public void SetSecrtaNumber()
    {
        System.Random rnd = new System.Random();
        SecrtaNumber = rnd.Next(1, 10);
    }

    public void PrentSecrtaNumber()
    {
        System.Console.WriteLine(SecrtaNumber);
    }

    public void GuessSecrtaNumber()
    { 
    System.Console.WriteLine("I now have a Secret, which I would like you to guess.");
        int GuessCount = 0;
        int Guess = 0;
        while (SecrtaNumber != Guess)
        {
            System.Console.WriteLine("Please enter a number between 1 and 10? ");
            string MyGuess = System.Console.ReadLine();
            int.TryParse(MyGuess, out Guess);
            if (Guess < SecrtaNumber)
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

        System.Console.WriteLine("You guessed the number! ");
        System.Console.WriteLine("It took you " + GuessCount + " tries. ");
    }

}       

public class FavoriteFoods
{
    string[] Position = { "first", "second", "third" };
    string[] FoodStorage;

    public void GetFavFood()
    {
        FoodStorage = new string[3];
        for (int i = 0; i < FoodStorage.Length; i++)
        {
            System.Console.WriteLine("Please enter your " + Position[i] + " Favorite Food? ");
            FoodStorage[i] = System.Console.ReadLine();
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        for (int i = 0;i < FoodStorage.Length; i++)
        {
            System.Console.WriteLine("Your " + Position[i] + " favorite food is " + FoodStorage[i] + "! ");
        }
    }


}


public class Program
{
    public static void Main()
    {
      /*  NumberGuesser ng = new NumberGuesser();
        ng.SetSecrtaNumber();
        ng.GuessSecrtaNumber();     */

        FavoriteFoods FF = new FavoriteFoods();
        FF.GetFavFood();
    }

}