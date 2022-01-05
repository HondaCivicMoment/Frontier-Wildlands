using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Tiles.DireWood
{
    public class DireWood : ModItem
    {
        public override void SetStaticDefaults() => DisplayName.SetDefault("Dire Wood Block");
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
            item.createTile = mod.TileType("DireWoodTile");
            item.consumable = true;
        }
    }
}