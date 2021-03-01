using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace tiled_transporter
{
    namespace TilesetLoader
    {
        [XmlRootAttribute("tileset")]
        public struct tileset_spec
        {
            char[] namespec;
            ushort countspec;
            tile_spec[] tiles;

            public tileset_spec(char[] namespec, ushort countspec, tile_spec[] tiles) : this()
            {
                this.namespec = namespec;
                this.countspec = countspec;
                this.tiles = tiles;
            }


            [XmlAttribute("name")]
            public char[] Namespec { get => namespec; set => namespec = value; }
            [XmlAttribute("tilecount")]
            public ushort Countspec { get => countspec; set => countspec = value; }
            [XmlArrayAttribute("tiles")]
            public tile_spec[] Tiles { get => tiles; set => tiles = value; }
        }
    }
}