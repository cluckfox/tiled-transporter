using System;

namespace tiled_transporter{
    namespace MapLoader{
        public struct tile_spec
        {
            public UInt32 data;

            public tile_spec(uint dataspec)
            {
                this.data = dataspec;
            }

            public byte TranslateType { get => (byte)(data >> 29); }
            public uint TileGid { get => data & 0x1FFFFFFF; }


            public override bool Equals(object obj)
            {
                return obj is tile_spec spec &&
                       data == spec.data;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(data);
            }
        }
    }
}