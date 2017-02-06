using System;
using System.Collections.Generic;

class Car
{
  private string _model;
  private int _price;
  private int _miles;
  private string _message;
  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (GetPrice() < maxPrice && GetMiles() < maxMiles);
  }
  public Car(string makeModel, int price, int miles, string message)
  {
    SetModel(makeModel);
    SetPrice(price);
    SetMiles(miles);
    SetMessage(message);
  }

  public void SetModel(string newModel)
  {
    _model = newModel;
  }

  public string GetModel()
  {
    return _model;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }

  public int GetMiles()
  {
    return _miles;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }

  public int GetPrice()
  {
    return _price;
  }

  public void SetMessage(string newMessage)
  {
    _message = newMessage;
  }

  public string GetMessage()
  {
    return _message;
  }


}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Why would you buy a car so expensive?");

    Car ford = new Car("2011 Ford F450", 55995, 14241, "This truck is huge!");

    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Nice and comfortable");

    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "The car you will soon own if you learn Nancy.");

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetModel());
    }
    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    int maxMiles = int.Parse(Console.ReadLine());

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetModel());
    }
  }
}
