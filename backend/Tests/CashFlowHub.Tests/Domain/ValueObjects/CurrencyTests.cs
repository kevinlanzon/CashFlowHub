using CashFlowHub.Domain.ValueObjects;
using Xunit;

namespace CashFlowHub.Tests.Domain.ValueObjects;

public class CurrencyTests
{
    [Fact]
    public void Currency_Should_Create_From_Valid_Code()
    {
        var currency = Currency.FromCode("USD");

        Assert.Equal("USD", currency.Code);
    }

    [Fact]
    public void Currency_Should_Convert_To_Uppercase()
    {
        var currency = Currency.FromCode("usd");

        Assert.Equal("USD", currency.Code);
    }

    [Fact]
    public void Currency_Should_Throw_When_Code_Is_Empty()
    {
        Assert.Throws<ArgumentException>(() => Currency.FromCode(""));
        Assert.Throws<ArgumentException>(() => Currency.FromCode("   "));
    }

    [Fact]
    public void Currency_Should_Throw_When_Code_Is_Invalid()
    {
        Assert.Throws<ArgumentException>(() => Currency.FromCode("XXX"));
        Assert.Throws<ArgumentException>(() => Currency.FromCode("INVALID"));
    }

    [Fact]
    public void Currency_Should_Support_Static_Properties()
    {
        var usd = Currency.Usd;
        var gbp = Currency.Gbp;
        var eur = Currency.Eur;

        Assert.Equal("USD", usd.Code);
        Assert.Equal("GBP", gbp.Code);
        Assert.Equal("EUR", eur.Code);
    }

    [Fact]
    public void Currency_Should_Be_Equal_When_Codes_Match()
    {
        var currency1 = Currency.FromCode("USD");
        var currency2 = Currency.FromCode("USD");

        Assert.Equal(currency1, currency2);
        Assert.True(currency1 == currency2);
    }

    [Fact]
    public void Currency_Should_Not_Be_Equal_When_Codes_Differ()
    {
        var usd = Currency.FromCode("USD");
        var gbp = Currency.FromCode("GBP");

        Assert.NotEqual(usd, gbp);
        Assert.True(usd != gbp);
    }

    [Fact]
    public void Currency_Should_Default_To_GBP()
    {
        var currency = new Currency();

        Assert.Equal("GBP", currency.Code);
    }

    [Fact]
    public void Currency_ToString_Should_Return_Code()
    {
        var currency = Currency.FromCode("GBP");

        var result = currency.ToString();

        Assert.Equal("GBP", result);
    }
}

