using DotNetInterviewTDD.Core;
using System;
using Xunit;

public class ValueVsReferenceTests
{
    [Fact]
    public void Increment_Should_Not_Modify_Original_ValueType()
    {
        int original = 5;

        int result = NumberUtilities.Increment(original);

        Assert.Equal(5, original);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Rename_Should_Modify_Original_ReferenceType()
    {
        var person = new Person("Alice");

        PersonUtilities.Rename(person, "Bob");

        Assert.Equal("Bob", person.Name);
    }
}
