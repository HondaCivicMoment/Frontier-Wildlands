using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Items.Crafting
{
    public class Jade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jade Gemstone");
            Tooltip.SetDefault("Glowing with immense energy/n Often seen on tribal equipment");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 18;
            item.value = 10000;
            item.rare = ItemRarityID.Cyan;

        }
    }
}
