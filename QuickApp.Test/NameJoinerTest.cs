using Xunit;

namespace QuickApp.Test
{
    public class NameJoinerTest
    {
        [Fact]
        public void ShouldJoinName()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Moussa", "Ndiaye");

            Assert.Equal("Moussa Ndiaye", fullName, ignoreCase: true);
        }

        [Fact]
        public void ShouldJoinName_SubstringContains()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Moussa", "Ndiaye");

            Assert.Contains(" ", fullName);
        }
    }
}
