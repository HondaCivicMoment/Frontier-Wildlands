using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace BlossomBeloved.Projectiles.Thrown
{
    public class HastaProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shaved Hasta");
        }
        public override void SetDefaults()
        {
            projectile.width = 52;
            projectile.height = 54;
            projectile.friendly = true;
            projectile.hide = true;
            projectile.maxPenetrate = 5;
            projectile.thrown = true;
            aiType = ProjectileID.JavelinFriendly; // Change this later since it needs to be less convoluted
        }
    }
}