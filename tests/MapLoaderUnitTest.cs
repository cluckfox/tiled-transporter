using System;
using Xunit;
using TestMap = tiled_transporter.MapLoader.map_spec;
using TestTile = tiled_transporter.MapLoader.tile_spec;
namespace tiled_transporter_xunit
{
    public class MapLoaderUnitTest
    {
        [Fact]
        public void MapSpecDefaultConstructorWorks()
        {
            TestMap testMap = new TestMap();

            Assert.Null(testMap.layer.name);
            Assert.Null(testMap.tileset.tileset);
            Assert.Null(testMap.layer.cdata);
            Assert.Equal((UInt32)0, testMap.tileset.firstGid);
        }

        [Fact]
        public void TileSpecDefaultConstructorWorks()
        {
            TestTile testTile = new TestTile();

            Assert.Equal((UInt32)0, testTile.data);
        }

        [Fact]
        public void TileSpecInitConstructorWorks()
        {
            UInt32 testData = 12345678;

            TestTile testTile = new TestTile(testData);

            Assert.Equal(testData, testTile.data);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3758096384, 7)]
        [InlineData(536870912, 1)]
        [InlineData(2147483648, 4)]
        public void TileSpecTranslateTypeIsTopThreeBits(UInt32 a, UInt32 expected)
        {
            TestTile testTile = new TestTile(a);

            Assert.Equal(expected, testTile.TranslateType);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(3758096391, 7)]
        [InlineData(3758096385, 1)]
        [InlineData(3758096388, 4)]
        public void TileSpecGidIs29Bits(UInt32 a, UInt32 expected)
        {
            TestTile testTile = new TestTile(a);

            Assert.Equal(expected, testTile.TileGid);
        }
    }
}