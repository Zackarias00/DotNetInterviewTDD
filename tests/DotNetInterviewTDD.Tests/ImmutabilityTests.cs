using DotNetInterviewTDD.Core;
using Xunit;

public class ImmutabilityTests
{
    [Fact]
    public void WithName_Should_Return_New_Instance()
    {
        var user = new User("Alice");

        var updated = user.WithName("Bob");

        Assert.Equal("Alice", user.Name);
        Assert.Equal("Bob", updated.Name);
        Assert.NotSame(user, updated);
    }
}
