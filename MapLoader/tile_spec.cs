using System;

namespace tiled_transporter{
    namespace MapLoader{
        struct tile_spec
        {
            UInt32 dataspec;

            public tile_spec(uint dataspec)
            {
                this.dataspec = dataspec;
            }

            public uint Dataspec { get => dataspec; set => dataspec = value; }
            public byte TranslateType { get => (byte)(dataspec >> 29); }
            public uint TileGid { get => dataspec & 0x1FFFFFFF; }


            public override bool Equals(object obj)
            {
                return obj is tile_spec spec &&
                       dataspec == spec.dataspec;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(dataspec);
            }
        }
    }
}