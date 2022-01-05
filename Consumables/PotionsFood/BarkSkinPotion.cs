using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Items.Consumables.PotionsFood
{
    public class BarkSkinPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bark Skin Potion");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
         
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Crafting.TreeBark>());
        }
    }
}