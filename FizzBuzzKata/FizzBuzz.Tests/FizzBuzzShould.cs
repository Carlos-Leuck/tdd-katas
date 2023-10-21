
namespace FizzBuzz.Tests;

[TestClass]
public class FizzBuzzShould
{
    [TestMethod]
    public void ConvertOneToOne()
    {
        Assert.AreEqual("1", FizzBuzz.Convert(1));
        Assert.AreEqual("2", FizzBuzz.Convert(2));
        Assert.AreEqual("Fizz", FizzBuzz.Convert(3));


    }


}