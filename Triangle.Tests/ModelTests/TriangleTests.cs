using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void MatchingTriangleSides_TriangleIsIsoceles_True()
  {
   TriangleOne newTriangle = new TriangleOne("2","2","3");
   Assert.AreEqual("Isoceles", newTriangle.MatchingTriangleSides());
  }
  [TestMethod]
   public void MatchingTriangleSides_TriangleScalene_True()
  {
   TriangleOne newTriangleInstance = new TriangleOne("10","7","3");
   Assert.AreEqual("Scalene Triangle", newTriangleInstance.MatchingTriangleSides());
  }

  [TestMethod]
   public void MatchingTriangleSides_TriangleEquilateral_True()
  {
   TriangleOne newTriangleEqui = new TriangleOne("10","10","10");
   Assert.AreEqual("Equilateral Triangle", newTriangleEqui.MatchingTriangleSides());
  }

  }
}