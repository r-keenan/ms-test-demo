global using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator.Library.Area.Test;

[TestClass]
public class RectangleTest
{
    Rectangle rectangle;
    
    // This is ran prior to every unit test.
    [TestInitialize]
    public void Setup()
    {
        rectangle = new Rectangle();
        rectangle.Width = 3;
        rectangle.Length = 4;
    }
    
    // THis is ran after every unit test
    [TestCleanup]
    public void Cleanup()
    {
        rectangle = null;
    }
    
    [TestMethod]
    public void PerimeterTest()
    {

        double expected = 14;

        double actual = rectangle.Perimeter();
        
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AreaTest()
    {

        double expected = 12;

        double actual = rectangle.Area();
        
        Assert.AreEqual(expected, actual);
    }
    
    
}