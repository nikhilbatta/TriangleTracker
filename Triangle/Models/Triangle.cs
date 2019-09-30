using System;
using System.Collections.Generic;

namespace Triangle {
public class TriangleOne
{
  public string SideOne;
  public string SideTwo;
  public string SideThree;
  
  public TriangleOne(string sideOne, string sideTwo , string sideThree) 
  {
    SideOne = sideOne;
    SideTwo = sideTwo;
    SideThree = sideThree;
  }
  public string MatchingTriangleSides() 
  {
    if (SideOne == SideTwo && SideTwo == SideThree) {
        return "Equilateral Triangle";
    } else if ((SideOne != SideTwo && SideTwo != SideThree) && SideThree != SideOne) {
      return "Scalene Triangle";
    } else {
      return "Isoceles";
    }
  }

 public bool IsTriangle() 
 {
   int sOne = int.Parse(SideOne);
   int sTwo = int.Parse(SideTwo);
   int sThree = int.Parse(SideThree);

   int maxSide = Math.Max(Math.Max(sOne,sTwo),sThree);
   int sumSides = sOne + sTwo + sThree;
   int sum2Smallest = sumSides - maxSide;
   if(maxSide > sum2Smallest){
     return false;
   } else {
     return true;
   }
  }
}
class Program
{
  static void Main()
  {
   Console.WriteLine("Size of side One");
   string StringSideOne = Console.ReadLine();
   Console.WriteLine("Size of side two");
   string StringSideTwo = Console.ReadLine();
   Console.WriteLine("Size of side three");
   string StringSideThree = Console.ReadLine();
    
    TriangleOne newTriangle =  new TriangleOne(StringSideOne, StringSideTwo, StringSideThree);
    string typeOfTriangle = newTriangle.MatchingTriangleSides();
   
     if (newTriangle.IsTriangle()) {
       Console.WriteLine(typeOfTriangle);
     } else {
       Console.WriteLine("This is not a triangle");
     }

  }
}
}