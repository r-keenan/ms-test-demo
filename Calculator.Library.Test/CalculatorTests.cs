namespace Calculator.Library.Test;

[TestClass]
public class CalculatorTests
{
    private TestContext _testContext;

    public TestContext TestContext
    {
        get
        {
            return _testContext;
        }
        set
        {
            _testContext = value;
        }
    }
    
    [TestMethod]
    public void Divide_PositiveNumbers_Test()
    {
        // Arrange
        int expected = 5;
        int numerator = 20;
        int denominator = 4;
        
        // Act
        int actual = Calculator.Divide(numerator, denominator);
        
        TestContext.WriteLine(actual.ToString());
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeQuotient_Test()
    {
        // Arrange
        int expected = -5;
        int numerator = 20;
        int denominator = -4;
        
        // Act
        int actual = Calculator.Divide(numerator, denominator);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Divide_NegativeNumbers_ReturnsPositiveQuotient_Test()
    {
        // Arrange
        int expected = 5;
        int numerator = -20;
        int denominator = -4;
        
        // Act
        int actual = Calculator.Divide(numerator, denominator);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
}