namespace WeatherRoulette;

public class Weather
{
    public string WeatherName { get; set;}
    private Outfit outfit { get; set; }

    public Weather(string weatherName, Outfit outfit)
    {
        WeatherName = weatherName;
        outfit = outfit;
    }

    public Weather()
    {

    }
}