using System;
using System.Collections.Generic;

namespace tiled_transporter
{
    namespace MapLoader
    {
        struct map_spec : IEquatable<map_spec>
        {
          char[] namespec;
          char[] tilesetspec;
          UInt32 firstgidspec;
          char[] cdataspec;

            public map_spec(char[] namespec, char[] tilesetspec, uint firstgidspec, char[] cdataspec)
            {
                this.namespec = namespec;
                this.tilesetspec = tilesetspec;
                this.firstgidspec = firstgidspec;
                this.cdataspec = cdataspec;
            }

            public char[] Namespec { get => namespec; set => namespec = value; }
            public char[] Tilesetspec { get => tilesetspec; set => tilesetspec = value; }
            public uint Firstgidspec { get => firstgidspec; set => firstgidspec = value; }
            public char[] Cdataspec { get => cdataspec; set => cdataspec = value; }

            public override bool Equals(object obj)
            {
                return obj is map_spec spec && Equals(spec);
            }

            public bool Equals(map_spec other)
            {
                return EqualityComparer<char[]>.Default.Equals(namespec, other.namespec) &&
                       EqualityComparer<char[]>.Default.Equals(tilesetspec, other.tilesetspec) &&
                       firstgidspec == other.firstgidspec &&
                       EqualityComparer<char[]>.Default.Equals(cdataspec, other.cdataspec);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(namespec, tilesetspec, firstgidspec, cdataspec);
            }

            public static bool operator ==(map_spec left, map_spec right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(map_spec left, map_spec right)
            {
                return !(left == right);
            }
        }
    }
}