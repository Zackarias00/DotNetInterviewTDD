using DotNetInterviewTDD.Core;
using Xunit;

public class InterfaceTests
{
    [Fact]
    public void OrderProcessor_Should_Use_PaymentService()
    {
        var fakePaymentService = new FakePaymentService(success: true);
        var processor = new OrderProcessor(fakePaymentService);

        bool result = processor.Process(100m);

        Assert.True(result);
        Assert.Equal(100m, fakePaymentService.LastChargedAmount);
    }
}
