namespace CashFlowHub.Domain.ValueObjects;

public record Currency(string Code)
{
    private static readonly HashSet<string> ValidCodes = new()
    {
        "USD", "GBP", "EUR", "JPY", "AUD", "CAD", "CHF", "CNY", "INR", "NZD"
    };

    public static Currency Usd => new("USD");
    public static Currency Gbp => new("GBP");
    public static Currency Eur => new("EUR");

    public Currency()
        : this("GBP") // Default to GBP
    {
    }

    public static Currency FromCode(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("Currency code cannot be empty", nameof(code));

        var upperCode = code.ToUpperInvariant();
        
        if (!ValidCodes.Contains(upperCode))
            throw new ArgumentException($"Invalid currency code: {code}", nameof(code));

        return new Currency(upperCode);
    }

    public override string ToString() => Code;
}

