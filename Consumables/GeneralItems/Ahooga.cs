using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Items.Consumables.GeneralItems
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
            item.useAnimation=10;
            item.useStyle=ItemUseStyleID.HoldingUp;
            item.value=50000;
            item.autoReuse=true;
            item.rare=ItemRarityID.LightPurple;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Mhorn");
            item.UseSound=SoundID.Item101;
        }
    }
}