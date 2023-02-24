using test_function;

namespace TestNewFunction;

public class TestNewFunction
{
    [Theory]
    [InlineData(4,5)]
    [InlineData(-10,-9)]
    [InlineData(-9,-8)]
    //[InlineData(1,1)]
    public void TestValueValues(int inputValue, int expectedValue)
    { 
        Assert.Equal(expectedValue, NewFunction.AFunction(inputValue));
    }
    [Theory]
    [InlineData(-15)]
    [InlineData(-11)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(int.MaxValue)]

    public void TestInvalidValues(int inputValue)
    {
        Assert.Throws<Exception>( () => NewFunction.AFunction(inputValue) );
    }
}