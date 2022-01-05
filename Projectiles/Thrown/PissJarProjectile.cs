using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
namespace BlossomBeloved.Projectiles.Thrown
{
    public class PissJarProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jarate");
        }
        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 28;
            projectile.friendly = true;
            projectile.thrown = true;
            aiType = ProjectileID.Shuriken; //change later on to be a jar that breaks with AoE piss
        }
    }
}