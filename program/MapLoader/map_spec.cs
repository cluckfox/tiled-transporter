using System;
using System.Collections.Generic;

namespace tiled_transporter
{
    namespace MapLoader
    {
        public struct map_spec
        {
            String namespec;
            String tilesetspec;
            UInt32 firstgidspec;
            String cdataspec;
            public map_spec(String namespec, String tilesetspec, UInt32 firstgidspec, String cdataspec)
            {
                this.namespec = namespec;
                this.tilesetspec = tilesetspec;
                this.firstgidspec = firstgidspec;
                this.cdataspec = cdataspec;
            }

            public String Namespec { get => namespec; set => namespec = value; }
            public String Tilesetspec { get => tilesetspec; set => tilesetspec = value; }
            public UInt32 Firstgidspec { get => firstgidspec; set => firstgidspec = value; }
            public String Cdataspec { get => cdataspec; set => cdataspec = value; }
        }
    }
}