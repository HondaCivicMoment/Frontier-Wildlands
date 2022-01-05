using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Items.Weapons
{
    public class PissJar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jarate");
            Tooltip.SetDefault("Might be apple juice");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 100;
            item.shootSpeed = 15f;
            item.shoot = ModContent.ProjectileType<Projectiles.Thrown.PissJarProjectile>();
            item.thrown = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 15;
            item.useTime = 15;
            item.rare = ItemRarityID.Yellow;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.damage = 3;
            item.crit = 0;
            item.UseSound = SoundID.Item1;
            item.consumable = true;
            item.maxStack = 999;

        }
    }
}