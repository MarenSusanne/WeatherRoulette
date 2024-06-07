namespace WeatherRoulette;

public class Game
{
    public List<Weather> weather;
    public List<Outfit> outfits;
    public int RightAnswer;

    public Game()
    {
        
        outfits = new List<Outfit>()
    {
        new Outfit("Caps", "Tank top", "Shorts", "Sandals"),
        new Outfit("Umbrella", "Raincoat", "Long pants", "Boots"),
        new Outfit("Beanie", "Puffer Jacket", "Warm pants", "Uggs"),
    };
        weather = new List<Weather>()
        {
        new Weather("Sunny", outfits[0]),
        new Weather("Rainy", outfits[1]),
        new Weather("Snowy", outfits[2]),
    };
}
    public void runGame()
    {
        
        Console.WriteLine("Welcome to chose your outfit!");
        Console.WriteLine("Do you want to play a game? Write yes");
        var playInput = Console.ReadLine();
            switch (playInput)
            {
                case "yes":
                    while (true)
                    {
                        //WeatherRoulette.Weather.Random();
                        Random();
                        ShowOutfits();
                        ChoseOutfit();
                        
                    }
                default:
                    Console.WriteLine("Oh well");
                    System.Environment.Exit(0);
                    break;
            }
        
    }

    
    public void Random()
    {

        Random rand = new Random();
        var randomNumber = rand.Next(1, 4);
        RightAnswer = randomNumber;
        if (randomNumber == 1)
        {
            Console.WriteLine($"Congrats! It is {weather[0].WeatherName} outside. Which of these outfits should you choose?");
        }
        else if (randomNumber == 2)
        {
            Console.WriteLine($"Damn, it is {weather[1].WeatherName} outside. Which of these outfits should you choose?");
        }
        else
        {
            Console.WriteLine($"Wonderful! It is {weather[2].WeatherName} outside. Which of these outfits should you choose?");
        }
    }
    public void ShowOutfits()
    {
        int i = 1;
        foreach (Outfit outfit in outfits)
        {
            Console.Write($"{i}. {outfit.Hat}, {outfit.Top}, {outfit.Bottoms}, {outfit.Shoes}");
            Console.WriteLine();
            i++;
        }
    }
    public void ChoseOutfit()
    {
        var answer = Console.ReadLine();
        if (answer == "1") //Sun
        {
            if (answer == $"{RightAnswer}")
            {
                Console.WriteLine("Superb! This will make you cool in the sun!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Oh no! You might be a bit to exposed in this!");
                Console.WriteLine();
            }
        }
        else if (answer == "2") //Rain
        {
            if (answer == $"{RightAnswer}")
            {
                Console.WriteLine("Perfect! This will keep you dry in the rain!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Damn! This might be a bit clammy.");
                Console.WriteLine();
            }
        }
        else if (answer == "3") //Snow
        {
            if (answer == $"{RightAnswer}")
            {
                Console.WriteLine("Cosy! This will keep you warm in the snow!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Woops! This might get a bit too hot.");
                Console.WriteLine();
            }
        }
    }
}