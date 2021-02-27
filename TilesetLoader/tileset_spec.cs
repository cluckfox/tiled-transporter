using System;
using System.Collections.Generic;

namespace tiled_transporter
{
    namespace TilesetLoader
    {
        struct tileset_spec
        {
            char[] namespec;

            public tileset_spec(char[] namespec, ushort countspec) : this()
            {
                this.namespec = namespec;
                this.countspec = countspec;
            }

            ushort countspec;

            public char[] Namespec { get => namespec; set => namespec = value; }
            public ushort Countspec { get => countspec; set => countspec = value; }

            public override bool Equals(object obj)
            {
                return obj is tileset_spec spec &&
                       EqualityComparer<char[]>.Default.Equals(namespec, spec.namespec) &&
                       countspec == spec.countspec;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(namespec, countspec);
            }
        }
    }
}