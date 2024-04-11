using P05_Decorator.Step3_Decorator;

namespace P05_DecoratorTests;

public class Step3Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_CalculateRent()
    {
        var sedanRental = new SedanRental(3);
        var vipSedanRental = new VipDiscountDecorator(sedanRental, new Customer(true));
        var fullVipSedanRental = new FullDiscountDecorator(vipSedanRental);
        decimal rent1 = fullVipSedanRental.CalculateRent();
        Assert.That(rent1, Is.EqualTo(450.0));

        var mpvRental = new MpvRental(7);
        var vipMpvRental = new VipDiscountDecorator(mpvRental, new Customer(true));
        decimal rent2 = vipMpvRental.CalculateRent();
        Assert.That(rent2, Is.EqualTo(1440.0));
    }
}