using System;
using Xunit;
using TestSquareFilter = tiled_transporter.SquareFilter<int>;
namespace tiled_transporter_xunit
{
    public class ValidatorsUnitTest
    {
        private TestSquareFilter squareFilter = new TestSquareFilter();
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
    }
}
