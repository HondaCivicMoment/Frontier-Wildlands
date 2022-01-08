using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlossomBeloved.Npcs.Friendly.BarkSummon
{
    public class BarkSummon : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endemic Member");
        }
        public override void SetDefaults()
        {
            //npc.CloneDefaults=NPCID.
            npc.width = 24;
            npc.height = 34;
            npc.friendly = true;
        }
    }
}