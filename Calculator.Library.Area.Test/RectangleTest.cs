global using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator.Library.Area.Test;

[TestClass]
public class RectangleTest
{
    [TestMethod]
    public void PerimeterTest()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 3;
        rectangle.Length = 4;

        double expected = 14;

        double actual = rectangle.Perimeter();
        
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AreaTest()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 3;
        rectangle.Length = 4;

        double expected = 12;

        double actual = rectangle.Area();
        
        Assert.AreEqual(expected, actual);
    }
}