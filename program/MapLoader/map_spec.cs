using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace tiled_transporter
{
    namespace MapLoader
    {
        [XmlRoot("map")]
        public struct map_spec
        {
            public struct tileset_spec
            {
                [XmlAttribute("firstgid")]
                public UInt32 firstGid;
                [XmlAttribute("source")]
                public String tileset;
            }

            public struct layer_spec
            {
                [XmlAttribute("name")]
                public String name;
                [XmlElement("data")]
                public String cdata;
            }

            [XmlElement("tileset")]
            public tileset_spec tileset;
            [XmlElement("layer")]
            public layer_spec layer;
        }
    }
}