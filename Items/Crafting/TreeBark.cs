using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Items.Crafting
{
    public class TreeBark : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Evergreen Bark");
            Tooltip.SetDefault("Hardened bark from the trees seen in the Frontier Wildlands /nUsed to craft Frontier related items");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 10;
            item.rare = ItemRarityID.White;

        }
    }
}
