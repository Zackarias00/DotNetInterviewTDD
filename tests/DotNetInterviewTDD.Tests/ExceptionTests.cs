using DotNetInterviewTDD.Core;
using System;
using Xunit;

public class ExceptionTests
{
    [Fact]
    public void Withdraw_Should_Throw_When_Insufficient_Funds()
    {
        var account = new BankAccount(balance: 50);

        Assert.Throws<InvalidOperationException>(() =>
            account.Withdraw(100)
        );
    }
}
