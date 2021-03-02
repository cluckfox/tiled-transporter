using System;
using Xunit;
using System.IO;
using System.Xml.Serialization;
using TilesetSpec = tiled_transporter.TilesetLoader.tileset_spec;
using MapSpec = tiled_transporter.MapLoader.map_spec;
namespace tiled_transporter_xunit
{
    public class LoaderSerializationUnitTest
    {
        // See https://dotnetcoretutorials.com/2020/04/23/how-to-parse-xml-in-net-core/
        [Fact]
        public void ImageCollectionTilesetWillLoad()
        {
            TilesetSpec tilesetSpec;
            String myXmlPath = "../../../testdata/8-bit-dungeon-cc0.tsx";
            using( var fileStream = File.Open(myXmlPath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TilesetSpec));
                tilesetSpec = (TilesetSpec)serializer.Deserialize(fileStream);

            }
            String testName = "8-bit-dungeon-cc0";
            Assert.Equal(testName,tilesetSpec.name);
            Assert.NotEmpty(tilesetSpec.tiles);
        }

        [Fact]
        public void TestMapWillLoad()
        {
            MapSpec mapSpec;
            String myXmlPath = "../../../testdata/base_meta.tmx";
            using(var fileStream = File.Open(myXmlPath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(MapSpec));
                mapSpec = (MapSpec)serializer.Deserialize(fileStream);
            }

            Assert.NotEmpty(mapSpec.layers);
            Assert.Equal("Tile Layer 1", mapSpec.layers[0].name);
            Assert.Equal((UInt32)1, mapSpec.layers[0].id);
            Assert.Equal("csv", mapSpec.layers[0].data.encoding);
            Assert.NotEmpty(mapSpec.layers[0].data.cdata);
            Assert.Equal((UInt32)1, mapSpec.tileset.firstGid);
            Assert.Equal("../Tilesets/8-bit-dungeon-cc0.tsx", mapSpec.tileset.tileset);
            
            
        }
    }
}