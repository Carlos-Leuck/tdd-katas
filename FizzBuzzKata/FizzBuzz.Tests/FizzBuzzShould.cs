
namespace FizzBuzz.Tests;

[TestClass]
public class FizzBuzzShould
{
    [TestMethod]
    public void ConvertOneToOne()
    {
        Assert.AreEqual("1", FizzBuzz.Convert(1));

    }


}