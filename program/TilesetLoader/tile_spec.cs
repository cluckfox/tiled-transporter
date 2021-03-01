using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace tiled_transporter {
    namespace TilesetLoader {

        public struct tile_spec {
            ushort idspec;
            image_spec imagespec;

            public tile_spec(ushort idspec, image_spec imagespec)
            {
                this.idspec = idspec;
                this.imagespec = imagespec;
            }

            [XmlAttribute("id")]
            public ushort Idspec { get => idspec; set => idspec = value; }
            [XmlElement("image")]
            public image_spec Imagespec { get => imagespec; set => imagespec = value; }
        }
    }
}