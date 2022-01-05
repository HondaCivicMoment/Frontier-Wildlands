using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved.Items.Equipment.Accessories
{
    public class PredatorNecklace : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Predator Necklace");
            Tooltip.SetDefault("Extra armor penetration");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 46;
            item.value = 10000;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SharkToothNecklace);
            //recipe.AddIngredient(ItemID.SharkToothNecklace);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe;
        }
        public override bool CanEquipAccessory(Player player, int slot)
        {
            return base.CanEquipAccessory(player, slot);
        }
    }
}