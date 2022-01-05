using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace BlossomBeloved.Buffs
{
    public class BarkSkinBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bark Skin");
            Description.SetDefault("Your skin is as tough as a tree");
            Main.buffNoTimeDisplay[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 10;
            player.moveSpeed -= 5f;
        }
    }
}