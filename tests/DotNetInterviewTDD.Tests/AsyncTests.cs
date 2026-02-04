using DotNetInterviewTDD.Core;
using System.Threading.Tasks;
using Xunit;

public class AsyncTests
{
    [Fact]
    public async Task GetDataAsync_Should_Return_Data()
    {
        var service = new DataService();

        string result = await service.GetDataAsync();

        Assert.Equal("data", result);
    }

    [Fact]
    public async Task GetDataAsync_Should_Not_Block()
    {
        var service = new DataService();

        Task<string> task = service.GetDataAsync();

        Assert.False(task.IsCompleted);
        await task;
    }
}
