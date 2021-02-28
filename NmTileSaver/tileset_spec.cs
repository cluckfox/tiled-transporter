using System;
using System.Collections.Generic;

namespace tiled_transporter
{
    namespace NmTileSaver
    {
        struct tileset_spec : IEquatable<tileset_spec>
        {
            char[] pathspec;
            ushort tileSizeSpec;
            ushort tilesetHeightSpec;
            ushort tilesetWidthSpec;

            public tileset_spec(char[] pathspec, ushort tileSizeSpec, ushort tilesetHeightSpec, ushort tilesetWidthSpec)
            {
                this.pathspec = pathspec;
                this.tileSizeSpec = tileSizeSpec;
                this.tilesetHeightSpec = tilesetHeightSpec;
                this.tilesetWidthSpec = tilesetWidthSpec;
            }

            public char[] Pathspec { get => pathspec; set => pathspec = value; }
            public ushort TileSizeSpec { get => tileSizeSpec; set => tileSizeSpec = value; }
            public ushort TilesetHeightSpec { get => tilesetHeightSpec; set => tilesetHeightSpec = value; }
            public ushort TilesetWidthSpec { get => tilesetWidthSpec; set => tilesetWidthSpec = value; }

            public override bool Equals(object obj)
            {
                return obj is tileset_spec spec && Equals(spec);
            }

            public bool Equals(tileset_spec other)
            {
                return EqualityComparer<char[]>.Default.Equals(pathspec, other.pathspec) &&
                       tileSizeSpec == other.tileSizeSpec &&
                       tilesetHeightSpec == other.tilesetHeightSpec &&
                       tilesetWidthSpec == other.tilesetWidthSpec;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(pathspec, tileSizeSpec, tilesetHeightSpec, tilesetWidthSpec);
            }

            public static bool operator ==(tileset_spec left, tileset_spec right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(tileset_spec left, tileset_spec right)
            {
                return !(left == right);
            }
        }
    }
}