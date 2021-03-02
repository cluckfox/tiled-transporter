using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace tiled_transporter
{
    namespace TilesetLoader
    {
        [XmlRoot("tileset")]
        public struct tileset_spec
        {
            public struct image_spec
            {
                [XmlAttribute("height")]
                public UInt32 height;
                [XmlAttribute("width")]
                public UInt32 width;
                [XmlAttribute("source")]
                public String source;
            }
            public struct tile_spec
            {
                [XmlAttribute("id")]
                public UInt32 id;
                [XmlElement("image")]
                public image_spec image;
            }
            [XmlAttribute("name")]
            public String name;
            [XmlAttribute("tilecount")]
            public UInt32 tileCount;
            [XmlElement("tile")]
            public List<tile_spec> tiles;

        }
    }
}