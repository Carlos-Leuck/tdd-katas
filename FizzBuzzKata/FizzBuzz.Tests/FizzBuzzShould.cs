
namespace FizzBuzz.Tests;

[TestClass]
public class FizzBuzzShould
{
    [TestMethod]
    public void ConvertIntegerToString()
    {
        Assert.AreEqual("1", FizzBuzz.Convert(1));
        Assert.AreEqual("2", FizzBuzz.Convert(2));
        Assert.AreEqual("4", FizzBuzz.Convert(4));

    }
    [TestMethod]
    public void ConvertThreeToFizz()
    {
        Assert.AreEqual("Fizz", FizzBuzz.Convert(3));

    }
    [TestMethod]
    public void ConvertFiveToBuzz()
    {
        Assert.AreEqual("Buzz", FizzBuzz.Convert(5));

    }

}