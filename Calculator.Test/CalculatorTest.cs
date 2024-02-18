namespace Calculator.Test;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void Divide_Test()
    {
        // Arrange
        int expected = 5;
        int numerator = 20;
        int denominator = 4;
        
        // Act
        int actual = Calculator.Library.Calculator.Divide(numerator, denominator);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
}