using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;

namespace BlossomBeloved.Tiles.DireWood.DireWoodTree
{
    public class DireWoodTree : ModTree
    {
        private Mod mod { get { return ModLoader.GetMod("BlossomBeloved"); } }
        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame){ return mod.GetTexture("Tiles/DireWood/DireWoodTreeBranches"); }
        public override Texture2D GetTexture(){return mod.GetTexture("Tiles/DireWood/DireWoodTree");}
        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset){ return mod.GetTexture("Tiles/DireWood/DireWoodTreeTops"); }
        public override int DropWood() { return ModContent.ItemType<Items.Crafting.TreeBark>(); }
    }
}