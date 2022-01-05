using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved
{
    public class MeatHook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meat Hook");
            Tooltip.SetDefault("Summons a little indigenonous tribe to fight alongside you");
        }
        public override void SetDefaults()
        {
            item.width = 58;
            item.height = 56;
            item.melee = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.channel = true;
            item.value = 50000;
            item.damage = 15;
            item.crit = 5;
            item.shoot = ModContent.ProjectileType<MeatHookProjectile>();
            item.shootSpeed = 15f;
            item.UseSound = SoundID.Item1;
            item.rare = ItemRarityID.Red;
        }
    }
}