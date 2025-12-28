namespace CashFlowHub.Domain.Events;

public record AccountCreated(
    Guid AccountId,
    string AccountName,
    decimal InitialBalance,
    DateTime CreatedAt
);
