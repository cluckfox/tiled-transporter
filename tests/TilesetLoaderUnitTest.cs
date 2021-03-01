using System;
using Xunit;
using TestTileset = tiled_transporter.TilesetLoader.tileset_spec;
using TestTile = tiled_transporter.TilesetLoader.tile_spec;
using TestImage = tiled_transporter.TilesetLoader.image_spec;
namespace tiled_transporter_xunit
{
    public class TilesetLoaderUnitTest
    {
        [Fact]
        public void TilesetDefaultConstructorWorks()
        {
            TestTileset testTileset = new TestTileset();

            Assert.Equal(0, testTileset.Countspec);
            Assert.Null(testTileset.Namespec);
            Assert.Null(testTileset.Tiles);
        }

        [Fact]
        public void TilesetInitConstructorWorks()
        {
            char[] testName;
            TestTile[] emptyTiles = {};

            String x = "test-tileset-name";
            testName = x.ToCharArray();
            ushort testCount = 11;

            TestTileset testTileset = new TestTileset(testName, testCount, emptyTiles);

            Assert.Equal(testName, testTileset.Namespec);
            Assert.Equal(testCount, testTileset.Countspec);
            Assert.Empty(testTileset.Tiles);
        }

        [Fact]
        public void TileDefaultConstructorWorks()
        {
            TestTile testTile = new TestTile();
            TestImage emptyImage = new TestImage();

            Assert.Equal(0, testTile.Idspec);
            Assert.Equal(emptyImage, testTile.Imagespec);
        }

        [Fact]
        public void TileInitConstructorWorks()
        {
            ushort testId = 11;
            TestImage testImage = new TestImage();
            TestTile testTile = new TestTile(testId, testImage);

            Assert.Equal(testId, testTile.Idspec);
            Assert.Equal(testImage, testTile.Imagespec);
        }

        [Fact]
        public void ImageDefaultConstructorWorks()
        {
            TestImage testImage = new TestImage();

            Assert.Equal(0, testImage.Heightspec);
            Assert.Equal(0, testImage.Widthspec);
            Assert.Null(testImage.Sourcespec);
        }

        [Fact]
        public void ImageInitConstructorWorks()
        {
            ushort testHeight = 11;
            ushort testWidth = 650;
            char[] testSource = { 'a', 'b', 'c' };

            TestImage testImage = new TestImage(testHeight, testWidth, testSource);

            Assert.Equal(testHeight, testImage.Heightspec);
            Assert.Equal(testWidth, testImage.Widthspec);
            Assert.Equal(testSource, testImage.Sourcespec);
        }
    }
}