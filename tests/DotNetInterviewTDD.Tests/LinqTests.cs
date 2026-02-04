using DotNetInterviewTDD.Core;
using System.Collections.Generic;
using Xunit;

public class LinqTests
{
    [Fact]
    public void FilterEven_Should_Use_Deferred_Execution()
    {
        var numbers = new List<int> { 1, 2, 3, 4 };

        var evens = NumberQueries.FilterEven(numbers);

        numbers.Add(6);

        Assert.Contains(6, evens);
    }
}
