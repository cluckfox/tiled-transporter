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
            Assert.Equal(testName,tilesetSpec.Namespec);
            Assert.NotEmpty(tilesetSpec.Tiles);
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

            Assert.Equal("Tile Layer 1", mapSpec.Namespec);
            Assert.Equal((UInt32)1, mapSpec.Firstgidspec);
            Assert.Equal("../Tilesets/8-bit-dungeon-cc0.tsx", mapSpec.Tilesetspec);
            Assert.NotEmpty(mapSpec.Cdataspec);
        }
    }
}