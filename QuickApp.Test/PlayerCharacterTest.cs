using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QuickApp.Test
{
    public class PlayerCharacterTest
    {
        [Fact]
        private void ShouldHaveDefaultRandomGenerateName()
        {
            var sut = new PlayerCharacter();

            var result = sut.Name;

            Assert.NotNull(result);
        }

        [Fact]
        private void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            var result = sut.NickName;

            Assert.Null(result);
        }

        [Fact]
        private void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            var result = sut.IsNoob;

            Assert.True(result);
        }

        [Fact]
        private void ShouldNotContainFooBar()
        {
            var sut = new PlayerCharacter();

            Assert.Contains("Bob", sut.Weapons);
        }
    }
}
