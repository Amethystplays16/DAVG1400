public class Grader
{
    public void Checkgrade()
    {
        int Score = -1;

        while (Score < 0 || Score > 100)          // This is a "If" staitment that lops until we get a corent number and is with in the peramiters we set
        {
            System.Console.WriteLine("What is your favorite Subjuct? ");
            string MySubjuct = System.Console.ReadLine();

            
            string MySubjctlc = MySubjuct.ToLower();        // This will make what ever someone writes lowercase so the progam can read it.
            MySubjctlc = MySubjctlc.Replace(" ", "");       // Her it will remova all spacese from what they write.
            switch (MySubjctlc)
            {                                       // Here are many diffrent responces to what might be writen.
                case "math":
                    Console.WriteLine("Keep prectings and memorizing those equation!");
                    break;
                case "english":
                    Console.WriteLine("Keep up that good Grammer");
                    break;
                case "history":
                    Console.WriteLine("Keep our History alive! ");
                    break;
                case "art":
                    Console.WriteLine("Show the world your art! ");
                    break;
                case "music":
                    Console.WriteLine("Let your music bring joy to everyone! ");
                    break;
                case "theater":
                    Console.WriteLine("Be a star on that stage! ");
                    break;
                case "physicaled":
                case "pe":
                    Console.WriteLine("Keep up that hard work, its paying off! ");
                    break;
                case "dance":
                    Console.WriteLine("Keep doing what you love! ");
                    break;
                case "health":
                    Console.WriteLine("Good job keeping yourself Health");
                    break;
                case "politicalscience":
                    Console.WriteLine("You will be a good politician");
                    break;
                case "computerscience":
                case "cs":
                case "coding":
                    Console.WriteLine("You are going to ba an amazing Programmer!");
                    break;
                default: Console.WriteLine("0");
                    break;
            }

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


        if (degrees >= 30)                                        // This is a "if, else" to determen if it is good weather outside and keep everyone safe.
            System.Console.WriteLine("Stay hydrated and avoid staying in the sun for too long.");
        else if (degrees >= 20)
            System.Console.WriteLine("Enjoy the wonderful weather! ");
        else if (degrees >= 10)
            System.Console.WriteLine("You might want to carrie a light jackie.");
        else if (degrees >= 0)
            System.Console.WriteLine("You should waer warm clothes when you go out!");
        else
            System.Console.WriteLine("You might want to stay inside and keep warm. ");
    }

}

internal class Program          // without Main we cannt run our progam
{
    public static void Main(string[] args)
    {
        Grader EnterGrades = new Grader();
        EnterGrades.Checkgrade();

        Weather CheckWeather = new Weather();
        CheckWeather.CheckTem();
    }

}