namespace MVC_Countries_Lab
{
  public class CountryListView
  {
    //properties
    public List<Country> Countries { get; set; }

    //constructor 
    public CountryListView(List<Country> _countries)
    {
      Countries = _countries;
    }

    //methods
    public void Display()
    {
      int i = 1;
      foreach (Country country in Countries)
      {
        Console.WriteLine($"{i}. {country.Name}");
        i++;
      }
    }
  }
}

