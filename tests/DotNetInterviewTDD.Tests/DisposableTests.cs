using DotNetInterviewTDD.Core;
using Xunit;

public class DisposableTests
{
    [Fact]
    public void Dispose_Should_Mark_Resource_As_Disposed()
    {
        var resource = new TestResource();

        resource.Dispose();

        Assert.True(resource.IsDisposed);
    }

    [Fact]
    public void Using_Should_Dispose_Resource()
    {
        TestResource resource;

        using (resource = new TestResource())
        {
            Assert.False(resource.IsDisposed);
        }

        Assert.True(resource.IsDisposed);
    }
}
