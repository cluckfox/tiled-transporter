using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace tiled_transporter {
    namespace TilesetLoader {

        struct tile_spec {
            ushort idspec;
            image_spec image_spec;

            public tile_spec(ushort idspec, image_spec image_spec)
            {
                this.idspec = idspec;
                this.image_spec = image_spec;
            }

            [XmlAttribute("id")]
            public ushort Idspec { get => idspec; set => idspec = value; }
            [XmlElement("image")]
            internal image_spec Image_spec { get => image_spec; set => image_spec = value; }
        }
    }
}