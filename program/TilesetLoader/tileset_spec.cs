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
            String namespec;
            ushort countspec;
            List<tile_spec> tiles;

            public tileset_spec(String namespec, ushort countspec, List<tile_spec> tiles) : this()
            {
                this.namespec = namespec;
                this.countspec = countspec;
                this.tiles = tiles;
            }


            [XmlAttribute("name")]
            public String Namespec { get => namespec; set => namespec = value; }
            [XmlAttribute("tilecount")]
            public ushort Countspec { get => countspec; set => countspec = value; }
            
            [XmlElement("tile")]
            public List<tile_spec> Tiles { get => tiles; set => tiles = value; }
        }
    }
}