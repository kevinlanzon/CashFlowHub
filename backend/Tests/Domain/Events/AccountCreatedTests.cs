using CashFlowHub.Domain.Events;
using Xunit;

namespace CashFlowHub.Tests.Domain.Events;

public class AccountCreatedTests
{
    [Fact]
    public void AccountCreated_Should_Have_Correct_Properties()
    {
        var accountId = Guid.NewGuid();
        var accountName = "Savings Account";
        var initialBalance = 1000.50m;
        var createdAt = DateTime.UtcNow;

        var accountCreated = new AccountCreated(
            accountId,
            accountName,
            initialBalance,
            createdAt
        );

        Assert.Equal(accountId, accountCreated.AccountId);
        Assert.Equal(accountName, accountCreated.AccountName);
        Assert.Equal(initialBalance, accountCreated.InitialBalance);
        Assert.Equal(createdAt, accountCreated.CreatedAt);
    }

    [Fact]
    public void AccountCreated_Should_Be_Equal_When_Properties_Match()
    {
        var accountId = Guid.NewGuid();
        var accountName = "Checking Account";
        var initialBalance = 500.00m;
        var createdAt = DateTime.UtcNow;

        var event1 = new AccountCreated(accountId, accountName, initialBalance, createdAt);
        var event2 = new AccountCreated(accountId, accountName, initialBalance, createdAt);

        Assert.Equal(event1, event2);
        Assert.True(event1 == event2); 
    }

    [Fact]
    public void AccountCreated_Should_Not_Be_Equal_When_Properties_Differ()
    {
        var accountId1 = Guid.NewGuid();
        var accountId2 = Guid.NewGuid();

        var event1 = new AccountCreated(accountId1, "Account 1", 100m, DateTime.UtcNow);
        var event2 = new AccountCreated(accountId2, "Account 2", 200m, DateTime.UtcNow);

        Assert.NotEqual(event1, event2);
        Assert.True(event1 != event2);
    }
}