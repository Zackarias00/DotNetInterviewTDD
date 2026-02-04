using DotNetInterviewTDD.Core;
using Xunit;

public class EqualityTests
{
    [Fact]
    public void Two_Users_With_Same_Id_Should_Be_Equal()
    {
        var a = new UserId(1);
        var b = new UserId(1);

        Assert.Equal(a, b);
        Assert.True(a == b);
    }
}
