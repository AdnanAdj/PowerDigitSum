using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    [TestCase(2453, 216)]   // 2^3 + 4^3 + 5^3 + 3^3 = 8 + 64 + 125 + 27 = 216
    [TestCase(1234, 100)]   // 1^3 + 2^3 + 3^3 + 4^3 = 1 + 8 + 27 + 64 = 100
    [TestCase(5678, 1421)]  // 5^3 + 6^3 + 7^3 + 8^3 = 125 + 216 + 343 + 512 = 1421
    [TestCase(9999, 2916)]  // 9^3 + 9^3 + 9^3 + 9^3 = 729 + 729 + 729 + 729 = 2916
    public void TestCalculatePowerSum(int input, int expected)
    {
        int actual = Program.CalculatePowerSum(input);
        Assert.AreEqual(expected, actual);
    }
}
