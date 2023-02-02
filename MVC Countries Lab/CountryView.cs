namespace MVC_Countries_Lab
{
  public class CountryView
  {
    //properties
    public Country DisplayCountry { get; set; }

    //constructor
    public CountryView(Country _country)
    {
      DisplayCountry = _country;
    }


    public void Display()
    {
      int i = 1;

      Console.WriteLine($"Country: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nColors:");
      foreach (var color in DisplayCountry.Colors)
        Console.Write($"{color} ");
    }
  }

}
