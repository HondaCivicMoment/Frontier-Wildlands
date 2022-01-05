using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlossomBeloved.Tiles
{
    public class FWTruffleTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            AddMapEntry(new Color(100, 100, 0));
            drop = mod.ItemType("LoamyDirt");
            soundStyle = 1;
        }
    }
}
