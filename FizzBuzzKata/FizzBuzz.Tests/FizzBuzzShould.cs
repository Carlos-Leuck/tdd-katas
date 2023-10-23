
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
        Assert.AreEqual("7", FizzBuzz.Convert(7));
        Assert.AreEqual("8", FizzBuzz.Convert(8));
        Assert.AreEqual("11", FizzBuzz.Convert(11));
        Assert.AreEqual("13", FizzBuzz.Convert(13));
        Assert.AreEqual("14", FizzBuzz.Convert(14));

    }
    [TestMethod]
    public void ConvertMultipleOfThreeToFizz()
    {
        Assert.AreEqual("Fizz", FizzBuzz.Convert(3));
        Assert.AreEqual("Fizz", FizzBuzz.Convert(6));
        Assert.AreEqual("Fizz", FizzBuzz.Convert(9));
        Assert.AreEqual("Fizz", FizzBuzz.Convert(12));

    }
    [TestMethod]
    public void ConvertMultipleOfFiveToBuzz()
    {
        Assert.AreEqual("Buzz", FizzBuzz.Convert(5));
        Assert.AreEqual("Buzz", FizzBuzz.Convert(10));

    }

}