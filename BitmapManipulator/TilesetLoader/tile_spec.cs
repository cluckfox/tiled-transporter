using System;
using System.Collections.Generic;

namespace tiled_transporter {
    namespace TilesetLoader {
        struct tile_spec {
            char[] filespec;

            public tile_spec(char[] filespec, ushort widthspec, ushort heightspec, ushort idspec) : this()
            {
                this.filespec = filespec;
                this.widthspec = widthspec;
                this.heightspec = heightspec;
                this.idspec = idspec;
            }

            ushort widthspec;
            ushort heightspec;
            ushort idspec;

            public char[] Filespec { get => filespec; set => filespec = value; }
            public ushort Widthspec { get => widthspec; set => widthspec = value; }
            public ushort Heightspec { get => heightspec; set => heightspec = value; }
            public ushort Idspec { get => idspec; set => idspec = value; }

            public override bool Equals(object obj)
            {
                return obj is tile_spec spec &&
                       EqualityComparer<char[]>.Default.Equals(filespec, spec.filespec) &&
                       widthspec == spec.widthspec &&
                       heightspec == spec.heightspec &&
                       idspec == spec.idspec;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(filespec, widthspec, heightspec, idspec);
            }
        }
    }
}