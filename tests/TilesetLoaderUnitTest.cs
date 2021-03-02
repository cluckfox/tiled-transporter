using System;
using System.Collections.Generic;
using Xunit;
using TestTileset = tiled_transporter.TilesetLoader.tileset_spec;

namespace tiled_transporter_xunit
{
    public class TilesetLoaderUnitTest
    {
        [Fact]
        public void TilesetDefaultConstructorWorks()
        {
            TestTileset testTileset = new TestTileset();

            Assert.Equal((UInt32)0, testTileset.tileCount);
            Assert.Null(testTileset.name);
            Assert.Null(testTileset.tiles);
        }
    }
}