namespace MVC_Countries_Lab
{
  public class CountryController
  {
    //properties
    List<Country> CountryDb = new List<Country>()
    {
      //North America
      new Country("United States", "North America", new List<string>() { "red", "white", "blue" }),
      new Country("Belize", "North America", new List<string>() { "red", "white", "blue" }),
      new Country("Costa Rica", "North America", new List<string>() { "blue", "white", "red" }),

      //South America
      new Country("Paraguay", "South America", new List<string>() { "red", "white", "blue" }),

      //Europe 
      new Country("Iceland", "Europe", new List<string>() { "blue", "white", "red" }),
      new Country("Croatia", "Europe", new List<string>() { "red", "white", "blue" }),
      new Country("Czech Republic", "Europe", new List<string>() { "blue", "white", "red" }),

      //Asia
      new Country("Laos", "Asia", new List<string>() { "red", "blue", "white" }),
      new Country("Nepal", "Asia", new List<string>() { "white", "blue", "red" }),
      
      //Australia
      new Country("New Zealand", "Australia", new List<string>() { "blue", "white", "red" }),

      //Antartica
      new Country("Antartica", "Antartica", new List<string>() { "blue", "white" }),
    };

    /*.Where(C => C.Name.StartsWith("a")==true).ToList();*/


    //methods
    public void CountryAction(Country c)
    {
      CountryView view = new CountryView(c);
      view.Display();
    }
    public void WelcomeAction()
    {
      bool getContinue = true;
      while (getContinue)
      {
        Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
        CountryListView place = new CountryListView(CountryDb);

        int choice = 0;
        place.Display();
        while (int.TryParse(Console.ReadLine(), out choice) == false)
        {
          Console.WriteLine($"Invalid selection. please enter a number from 1-{CountryDb.Count}.");
        }

        Console.Clear();
        Country c = CountryDb[choice - 1];
        Console.WriteLine(c.Name);
        CountryAction(c);

        //continue?
        while (getContinue)
        {
          Console.WriteLine("\nWould you like to learn about more countries? (yes/no)");
          string response = Console.ReadLine();
          if (response == "yes")
          {
            Console.Clear();
            getContinue = true;
            break;
          }
          else if (response == "no")
          {
            Console.Clear();
            getContinue = false;
            Console.WriteLine("Have a good day.");
            break;
          }
          else
          {
            Console.WriteLine("Invalid response try again");
          }
        }
      }
    }
  }
}

//for changing colors
//Enum.Parse<ConsoleColor>(color)