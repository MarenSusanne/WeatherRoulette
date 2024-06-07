namespace WeatherRoulette;

public class Outfit
{
    public string Hat { get; set; }
    public string Top { get; set; }
    public string Bottoms { get; set; }
    public string Shoes { get; set; }

    public Outfit(string hat, string top, string bottoms, string shoes)
    {
        Hat = hat;
        Top = top;
        Bottoms = bottoms;
        Shoes = shoes;
    }

    public Outfit()
    {

    }
}