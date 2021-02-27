using System;

namespace tiled_transporter
{
    namespace BitmapManipulator
    {

        /// <summary>Class <c>Resizer</c> represents parameters for a
        /// tile-to-tile transformation.</summary>
        struct Resizer
        {
            public enum ResizeOps : byte
            {
                NOP = 0x00,
                HFLIP = 0x01,
                VFLIP = 0x02,
                R1ROT = 0x04,
                R2ROT = 0x08
            }
            
            byte targetW;
            byte targetH;
            ResizeOps ops;

            public Resizer(byte targetW, byte targetH, ResizeOps ops)
            {
                this.targetW = targetW;
                this.targetH = targetH;
                this.ops = ops;
            }



            public byte TargetH { get => targetH; set => targetH = value; }
            public byte TargetW { get => targetW; set => targetW = value; }
            internal ResizeOps Ops { get => ops; set => ops = value; }

            public override bool Equals(object obj)
            {
                return obj is Resizer resizer &&
                       ops == resizer.ops &&
                       targetW == resizer.targetW &&
                       targetH == resizer.targetH;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(ops, targetW, targetH);
            }
        }

    }
}