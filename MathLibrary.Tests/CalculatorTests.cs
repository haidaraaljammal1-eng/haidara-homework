using Xunit;
using MathLibrary;

namespace MathLibrary.Tests;

public class CalculatoTests
{
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int a = 2, b = 3;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        // Arrange
        int a = 0, b = 5;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositiveNumbers_ReturnsNegative()
    {
        // Arrange
        int a = -2, b = 3;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        // Arrange
        int a = -2, b = -3;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(6, result);
    }
    
    // ===== Divide Tests =====

    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10, b = 2;

        // Act
        int result = Calculator.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10, b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }

    [Fact]
    public void Divide_NegativeByPositive_ReturnsNegative()
    {
        // Arrange
        int a = -10, b = 2;

        // Act
        int result = Calculator.Divide(a, b);

        // Assert
        Assert.Equal(-5, result);
    }

    // ===== IsEven Tests =====

    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        int a = 4;

        // Act
        bool result = Calculator.IsEven(a);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        // Arrange
        int a = 3;

        // Act
        bool result = Calculator.IsEven(a);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        // Arrange
        int a = 0;

        // Act
        bool result = Calculator.IsEven(a);

        // Assert
        Assert.True(result);
    }
}