using System;
using System.Collections.Generic;

namespace tiled_transporter
{
    namespace MapLoader
    {
        using TileSpecList = List<tile_spec>;
        public class DataLoader
        {
            public static List<tile_spec> FromCsv(String csvData)
            {
                TileSpecList tiles = new TileSpecList();

                var pieces = csvData.Split(',');
                foreach(var piece in pieces)
                {
                    tiles.Add(new tile_spec(Convert.ToUInt32(piece.Trim())));
                }
                
                return tiles;
            }
        }
    }
}