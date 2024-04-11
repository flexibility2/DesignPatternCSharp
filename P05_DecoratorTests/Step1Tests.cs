using P05_Decorator.Step1;

namespace P05_DecoratorTests;

public class Step1Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CalculateRent()
    {
        Rental rental1 = new Rental(new Customer(true), CarType.Sedan, 3, true);
        decimal rent1 = rental1.CalculateRent();
        Assert.That(rent1, Is.EqualTo(450.0));

        Rental rental2 = new Rental(new Customer(true), CarType.Mpv, 7, false);
        decimal rent2 = rental2.CalculateRent();
        Assert.That(rent2, Is.EqualTo(1440.0));
    }
}