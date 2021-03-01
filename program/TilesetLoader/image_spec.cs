using System;
using System.Xml;
using System.Xml.Serialization;
namespace tiled_transporter
{
    namespace TilesetLoader
    {
        public struct image_spec
        {
            ushort heightspec;
            ushort widthspec;
            String sourcespec;

            public image_spec(ushort heightspec, ushort widthspec, String sourcespec)
            {
                this.heightspec = heightspec;
                this.widthspec = widthspec;
                this.sourcespec = sourcespec;
            }

            [XmlAttribute("height")]
            public ushort Heightspec { get => heightspec; set => heightspec = value; }
            [XmlAttribute("width")]
            public ushort Widthspec { get => widthspec; set => widthspec = value; }
            [XmlAttribute("source")]
            public String Sourcespec { get => sourcespec; set => sourcespec = value; }
        }
    }
}