using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlossomBeloved.Tiles
{
    public class FWTruffle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wild Truffle");
            Tooltip.SetDefault("Woah Trippy Mushroom");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 15;
            item.useTime = 10;
            item.rare = ItemRarityID.White;
            item.autoReuse = true;
            item.createTile = mod.TileType("FWTruffleTile");
            item.consumable = true;
        }
    }
}