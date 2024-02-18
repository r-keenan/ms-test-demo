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
        
        System.Diagnostics.Debug.WriteLine($"Debug: {actual.ToString()}");
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

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_DenominatorIsZero_ThrowDivideByZeroException_Test()
    {
        // Arrange
        int numerator = 20;
        int denominator = 0;

        // Act
        try
        {
            Calculator.Divide(numerator, denominator);
        }
        catch (DivideByZeroException ex)
        {
            Assert.AreEqual("Denominator cannot be zero!", ex.Message);
            throw;
        }
    }
}