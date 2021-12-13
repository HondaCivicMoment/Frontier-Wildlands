using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlossomBeloved.Items
{
    public class ahooga : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("ZAMNNN!!!!!");
        }
        public override void SetDefaults()
        {
            item.height=44;
            item.width=54;
            item.useTime=10;
            item.useAnimation=10;
            item.useStyle=ItemUseStyleID.HoldingOut;
            item.value=50000;
            item.autoReuse=true;
            item.rare=ItemRarityID.LightPurple;
            //going back to change this to a random sound ID that is extracted from something like audio jungle.
            item.UseSound=SoundID.Item101;
        }
    }
}