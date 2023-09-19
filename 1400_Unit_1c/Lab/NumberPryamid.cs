public class NumberPryamid
{

    public static void Main()
    {
                                        // Here is where we will start building the Pryamid

        System.Console.WriteLine(" Please enter a positive Number");        //Here we ask the user to enter a number for it
        int Number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= Number; i++)        //Now this is how we take the number the user entered and make it into a Pryamid      
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);          // Then it will be increasted by 1
            }
            System.Console.WriteLine();         //This wiil move down a line
        }
        Console.ReadKey();                  


    }

}