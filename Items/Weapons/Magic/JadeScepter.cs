using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved
{
    public class JadeScepter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jade Scepter");
            Tooltip.SetDefault("Summons a little indigenonous tribe to fight alongside you");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}