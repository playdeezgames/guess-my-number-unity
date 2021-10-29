using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Scipts
{
    public static class Tiles
    {
        private static Dictionary<byte, Tile> table;
        public static Tile Read(byte character)
        {
            if(table==null)
            {
                table = new Dictionary<byte, Tile>();
                for(int index=0;index<256;++index)
                {
                    table[(byte)index] = Resources.Load<Tile>($"Tiles/romfont8x8_{index}");
                }
            }
            return table[character];
        }
    }
}
