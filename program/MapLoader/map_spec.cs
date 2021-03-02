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
            public struct data_spec
            {
                [XmlAttribute("encoding")]
                public String encoding;
                [XmlText]
                public String cdata;
            }
            public struct tileset_spec
            {
                [XmlAttribute("firstgid")]
                public UInt32 firstGid;
                [XmlAttribute("source")]
                public String tileset;
            }

            public struct layer_spec
            {
                [XmlAttribute("id")]
                public UInt32 id;
                [XmlAttribute("name")]
                public String name;

                [XmlElement("data")]
                public data_spec data;
            }

            [XmlElement("tileset")]
            public tileset_spec tileset;
            [XmlElement("layer")]
            public List<layer_spec> layers;
        }
    }
}