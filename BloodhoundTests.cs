namespace Bloodhound.Test;

[TestClass]
public class BloodhoundTests
{
    [TestMethod]
    public void ShouldReturnZero()
    {
        int valor = 8;

        var returnsValue = valor.ReturnSameValue();

        Assert.AreEqual(8, returnsValue);
    }
}