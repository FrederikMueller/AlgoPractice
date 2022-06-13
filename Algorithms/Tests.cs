using Algorithms.Medium;
using Xunit;

namespace Algorithms;
public class Tests
{
    ZigZagConversion classToTest;

    public Tests()
    {
        classToTest = new ZigZagConversion();
    }

    [Theory]
    [InlineData("PAHNAPLSIIGYIR", "PAYPALISHIRING", 3)]
    [InlineData("PINALSIGYAHRPI", "PAYPALISHIRING", 4)]
    [InlineData("A", "A", 1)]
    [InlineData("AB", "AB", 1)]
    public void Test(string expected, string input, int rows)
    {
        Assert.Equal(expected, classToTest.Solution(input, rows));
    }
}