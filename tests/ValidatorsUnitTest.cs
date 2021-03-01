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
        [Theory]
        [InlineData(32,32)]
        [InlineData(1,1)]
        [InlineData(699,699)]
        public void SquareFilterAcceptsSquare(int height, int width)
        {
            var result = this.squareFilter.test(height, width);
            Assert.True(result);
        }

        [Theory]
        [InlineData(32,31)]
        [InlineData(1,106)]
        [InlineData(755,756)]
        public void SquareFilterRejectsNotSquare(int height, int width)
        {
            var result = this.squareFilter.test(height, width);
            Assert.False(result);
        }

        [Theory]
        [InlineData(0,1)]
        [InlineData(1,0)]
        public void SquareFilterRejectsZero(int height, int width)
        {
            var result = this.squareFilter.test(height, width);
            Assert.False(result);
        }

        [Theory]
        [InlineData(-32,-32)]
        [InlineData(-1, 1)]
        [InlineData(1, -1)]
        public void SquareFilterRejectsNegative(int height, int width)
        {
            var result = this.squareFilter.test(height, width);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(131072)]
        public void Base2FilterAcceptsPowersOfTwo(int dat)
        {
            var result = this.base2Filter.test(dat, dat);
            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(131074)]
        public void Base2FilterRejectsNonPowersOfTwo(int dat)
        {
            var result = this.base2Filter.test(dat, dat);
            Assert.False(result);
        }
    }
}
