using NUnit.Framework;
using Calculator;

namespace Calculator.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator.Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator.Calculator();
    }

    [Test]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract_ReturnsCorrectDifference()
    {
        var result = _calculator.Subtract(5, 3);
        Assert.That(result, Is.EqualTo(2));
    }
}
