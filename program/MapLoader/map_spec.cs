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
                public UInt32 firstgidspec;
                [XmlAttribute("source")]
                public String tilesetspec;
            }

            public struct layer_spec
            {
                [XmlAttribute("name")]
                public String namespec;
                [XmlElement("data")]
                public String cdataspec;
            }

            [XmlElement("tileset")]
            public tileset_spec tileset;
            [XmlElement("layer")]
            public layer_spec layer;
            public map_spec(String namespec, String tilesetspec, UInt32 firstgidspec, String cdataspec)
            {
                this.tileset = new tileset_spec();
                this.layer = new layer_spec();
                this.layer.namespec = namespec;
                this.tileset.tilesetspec = tilesetspec;
                this.tileset.firstgidspec = firstgidspec;
                this.layer.cdataspec = cdataspec;
            }


            public String Namespec { get => layer.namespec; set => layer.namespec = value; }

            public String Tilesetspec { get => tileset.tilesetspec; set => tileset.tilesetspec = value; }

            public UInt32 Firstgidspec { get => tileset.firstgidspec; set => tileset.firstgidspec = value; }

            public String Cdataspec { get => layer.cdataspec; set => layer.cdataspec = value; }
        }
    }
}