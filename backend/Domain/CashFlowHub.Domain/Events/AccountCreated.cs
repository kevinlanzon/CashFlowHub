using CashFlowHub.Domain.ValueObjects;

namespace CashFlowHub.Domain.Events;

public record AccountCreated(
    Guid AccountId,
    string AccountName,
    decimal InitialBalance,
    Currency Currency,
    DateTime CreatedAt
);

