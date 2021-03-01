using System;
using Xunit;
using TestSquareFilter = tiled_transporter.SquareFilter<int>;
using TestBase2Filter = tiled_transporter.Base2Filter<int>;
namespace tiled_transporter_xunit
{
    public class ValidatorsUnitTest
    {
        private TestSquareFilter squareFilter = new TestSquareFilter();
        private TestBase2Filter base2Filter = new TestBase2Filter();
        [Fact]
        public void SquareFilterAcceptsSquare()
        {
            var result = this.squareFilter.test(32, 32);
            Assert.True(result);
        }

        [Fact]
        public void SquareFilterRejectsNotSquare()
        {
            var result = this.squareFilter.test(16,31);
            Assert.False(result);
        }

        [Fact]
        public void SquareFilterRejectsZero()
        {
            var result = this.squareFilter.test(0,0);
            Assert.False(result);
        }

        [Fact]
        public void SquareFilterRejectsNegative()
        {
            var result = this.squareFilter.test(-32,-32);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(256)]
        [InlineData(131072)]
        public void Base2FilterAcceptsPowersOfTwo(int dat)
        {
            var result = this.base2Filter.test(dat, dat);
            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(257)]
        [InlineData(131074)]
        public void Base2FilterRejectsNonPowersOfTwo(int dat)
        {
            var result = this.base2Filter.test(dat, dat);
            Assert.False(result);
        }
    }
}
