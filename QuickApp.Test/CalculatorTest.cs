using Xunit;

namespace QuickApp.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void ShoudAdd()
        {
            var sut = new Calculator();

            var result = sut.Add(1, 2);

            Assert.Equal(3, result);
        }
    }
}
