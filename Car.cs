using System;
using System.Collections.Generic;

class Car 
{
   public string MakeModel;
  public int Price;
  public int Miles;
  public string Message;

  public Car(string makeModel, int price, int miles, string message) 
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }
  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);  
  }
  public bool MaxMileage(int maxMileage) {
      return (Miles < maxMileage);
  }
}

class Program
{
  static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Mileage of this car is really good");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "Mileage of yugo is really good");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Mileage of ford is really good");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "Mileage of amc is really good");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
     Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMileage = int.Parse(stringMaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice) && automobile.MaxMileage(maxMileage))
      {
        CarsMatchingSearch.Add(automobile);
      } 
    }
      if (CarsMatchingSearch.Count == 0) {
        Console.WriteLine("There is no car available according to your search");
      }
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }// program code goes here
  }
}