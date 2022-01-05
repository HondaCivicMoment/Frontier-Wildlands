using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved
{
    public class BarkBat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Primative Baton");
            Tooltip.SetDefault("A Baton made of wood and bark/n Bonk!");
        }
        public override void SetDefaults()
        {
            item.width = 56;
            item.height = 56;
            item.damage = 17;
            item.crit = 5;
            item.melee = true;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 10;
            item.useTime = 10;
            item.value = 5000;
            item.rare = ItemRarityID.Green;
            item.useStyle = ItemUseStyleID.SwingThrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Crafting.TreeBark>(), 5);
            recipe.AddIngredient(ModContent.ItemType<Tiles.DireWood.DireWood>(), 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}