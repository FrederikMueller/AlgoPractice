using Xunit;

namespace Algo_Practice;
public class Tests
{
    Calcs calcs;
    Medium mAlgos;

    public Tests()
    {
        calcs = new Calcs();
        mAlgos = new Medium();
    }

    [Theory]
    [InlineData("PAHNAPLSIIGYIR", "PAYPALISHIRING", 3)]
    [InlineData("PINALSIGYAHRPI", "PAYPALISHIRING", 4)]
    [InlineData("A", "A", 1)]
    [InlineData("AB", "AB", 1)]
    public void MultiplyBasicTests(string expected, string input, int rows)
    {
        Assert.Equal(expected, mAlgos.Convert(input, rows));
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void MultiManyNumbersTestTheory(params int[] ints)
    {
        Assert.Equal(ints[0], calcs.Multiply(ints[1], ints[2]));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { 9, 3, 3 };
        yield return new object[] { 21, 3, 7 };
        yield return new object[] { -66, 22, -3 };
        yield return new object[] { 54, 27, 2 };
        yield return new object[] { 42, 7, 6 };
        yield return new object[] { 42, 7, 6 };
        yield return new object[] { 4, 2, 2 };
    }
}