
namespace FizzBuzz.Tests;

[TestClass]
public class FizzBuzzTest
{
    [DataTestMethod]
    [DataRow("1", 1)]
    [DataRow("2", 2)]
    [DataRow("4", 4)]
    [DataRow("7", 7)]
    [DataRow("11", 11)]
    public void ShouldConvertIntegerToString(string expected, int actual)
    {
        Assert.AreEqual(expected, FizzBuzz.Convert(actual));
    }

    [TestMethod]
    public void ShouldConvertMultipleOfThreeToFizz()
    {
        Assert.AreEqual("Fizz", FizzBuzz.Convert(3));
        Assert.AreEqual("Fizz", FizzBuzz.Convert(6));

    }

    [TestMethod]
    public void ShouldConvertMultipleOfFiveToBuzz()
    {
        Assert.AreEqual("Buzz", FizzBuzz.Convert(5));
        Assert.AreEqual("Buzz", FizzBuzz.Convert(10));
    }
    [TestMethod]
    public void ShouldConvertMultipleOfThreeAndFiveToFizzBuzz()
    {
        Assert.AreEqual("FizzBuzz", FizzBuzz.Convert(15));
        Assert.AreEqual("FizzBuzz", FizzBuzz.Convert(30));
    }

}