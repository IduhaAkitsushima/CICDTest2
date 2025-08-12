using Xunit;
using TestLib;

namespace TestLib.Test
{
    public class Class1Tests
    {
        [Fact]
        public void Add_ReturnsSum_WhenGivenTwoIntegers()
        {
            // Arrange
            var class1 = new Class1();

            // Act
            int result = class1.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ReturnsSum_WhenGivenTwoIntegers2()
        {
            // Arrange
            var class1 = new Class1();

            // Act
            int result = class1.Add(2, 3);

            // Assert
            Assert.Equal(6, result);
        }
    }
}