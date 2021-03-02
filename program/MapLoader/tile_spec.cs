using System;

namespace tiled_transporter{
    namespace MapLoader{
        public struct tile_spec : IComparable<tile_spec>, IComparable<UInt32>
        {
            public UInt32 data;

            public tile_spec(uint dataspec)
            {
                this.data = dataspec;
            }

            public byte TranslateType { get => (byte)(data >> 29); }
            public uint TileGid { get => data & 0x1FFFFFFF; }

            public int CompareTo(uint other)
            {
                return data.CompareTo(other);
            }

            public int CompareTo(tile_spec other)
            {
                return CompareTo(other.data);
            }
        }
    }
}