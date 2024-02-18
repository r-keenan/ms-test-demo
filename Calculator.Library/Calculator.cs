namespace Calculator.Library;

public class Calculator
{
    public static int Divide(int numerator, int denominator)
    {
        int result = numerator / denominator;
        Console.WriteLine(result);
        return result;
    }
    
    //[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    // This attribute is used to remove a method from code coverage results. should be used if the function does not need to be unit tested.
    // It can be used on more than just methods.
    public static int Add(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }
}