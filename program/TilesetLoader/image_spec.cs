using System.Xml;
using System.Xml.Serialization;
namespace tiled_transporter
{
    namespace TilesetLoader
    {
        struct image_spec
        {
            ushort heightspec;
            ushort widthspec;
            char[] sourcespec;

            public image_spec(ushort heightspec, ushort widthspec, char[] sourcespec)
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
            public char[] Sourcespec { get => sourcespec; set => sourcespec = value; }
        }
    }
}