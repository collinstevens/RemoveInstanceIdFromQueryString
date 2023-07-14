namespace RemoveInstanceIdFromQueryString.UnitTests;

public sealed class LibraryTests
{
    public sealed class RemoveInstanceIdFromQueryString_Old
    {
        [Theory]
        [InlineData("", null)]
        [InlineData("test=", "test=")]
        [InlineData("test=1234", "test=1234")]
        [InlineData("test=1234&instanceId=", "test=1234")]
        [InlineData("test=1234&instanceId=1234", "test=1234")]
        [InlineData("test=1234&instanceId=1234&test2=", "test=1234&test2=")]
        [InlineData("test=1234&instanceId=1234&test2=1234", "test=1234&test2=1234")]
        [InlineData("instanceId=&test=1234", "test=1234")]
        [InlineData("instanceId=1234&test=1234", "test=1234")]
        [InlineData("instanceId=1234&test=1234&test2=", "test=1234&test2=")]
        [InlineData("instanceId=1234&test=1234&test2=1234", "test=1234&test2=1234")]
        public void ShouldReturnExpectedOutputForGiven(string given, string expected)
        {
            // Act
            var result = Library.RemoveInstanceIdFromQueryString_Old(given);

            // Assert
            result.Should().Be(expected);
        }
    }
    
    public sealed class RemoveInstanceIdFromQueryString_New
    {
        [Theory]
        [InlineData("", null)]
        [InlineData("test=", "test=")]
        [InlineData("test=1234", "test=1234")]
        [InlineData("test=1234&instanceId=", "test=1234")]
        [InlineData("test=1234&instanceId=1234", "test=1234")]
        [InlineData("test=1234&instanceId=1234&test2=", "test=1234&test2=")]
        [InlineData("test=1234&instanceId=1234&test2=1234", "test=1234&test2=1234")]
        [InlineData("instanceId=&test=1234", "test=1234")]
        [InlineData("instanceId=1234&test=1234", "test=1234")]
        [InlineData("instanceId=1234&test=1234&test2=", "test=1234&test2=")]
        [InlineData("instanceId=1234&test=1234&test2=1234", "test=1234&test2=1234")]
        public void ShouldReturnExpectedOutputForGiven(string given, string expected)
        {
            // Act
            var result = Library.RemoveInstanceIdFromQueryString_New(given);

            // Assert
            result.Should().Be(expected);
        }
    }
    
    public sealed class RemoveInstanceIdFromQueryString_Fowler
    {
        [Theory]
        [InlineData("", null)]
        [InlineData("test=", "test=")]
        [InlineData("test=1234", "test=1234")]
        [InlineData("test=1234&instanceId=", "test=1234")]
        [InlineData("test=1234&instanceId=1234", "test=1234")]
        [InlineData("test=1234&instanceId=1234&test2=", "test=1234&test2=")]
        [InlineData("test=1234&instanceId=1234&test2=1234", "test=1234&test2=1234")]
        [InlineData("instanceId=&test=1234", "test=1234")]
        [InlineData("instanceId=1234&test=1234", "test=1234")]
        [InlineData("instanceId=1234&test=1234&test2=", "test=1234&test2=")]
        [InlineData("instanceId=1234&test=1234&test2=1234", "test=1234&test2=1234")]
        public void ShouldReturnExpectedOutputForGiven(string given, string expected)
        {
            // Act
            var result = Library.RemoveInstanceIdFromQueryString_Fowler(given);

            // Assert
            result.Should().Be(expected);
        }
    }
}