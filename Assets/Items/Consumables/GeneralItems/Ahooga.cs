using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlossomBeloved.Assets.Items.Consumables.GeneralItems
{
    public class Ahooga : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ahooga Fish");
            Tooltip.SetDefault("Haha Funny Fish");
        }
        
        public override void SetDefaults()
        {
            item.height=44;
            item.width=54;
            item.useTime=500;
            item.useAnimation=500;
            item.useStyle=ItemUseStyleID.HoldingUp;
            item.value=50000;
            item.autoReuse=true;
            item.rare=ItemRarityID.LightPurple;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Mhorn");
        }
    }
}