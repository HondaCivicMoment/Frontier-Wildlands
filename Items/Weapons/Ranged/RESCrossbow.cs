using Terraria.ID;
using Terraria.ModLoader;

namespace BlossomBeloved
{
    public class RESCrossbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Recurve Crossbow");
            Tooltip.SetDefault("A basic crossbow suited for basic hunting purposes");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.damage = 10;
            item.crit = 2;
            item.useTime = 15;
            item.useAnimation = 15;
            item.ranged = true;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 30f;
            item.knockBack = 4;
            item.rare = ItemRarityID.Green;
            item.value = 3000;
            item.noMelee = true;
            item.UseSound = SoundID.Item10;
            item.useStyle = ItemUseStyleID.HoldingOut;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.WhiteString);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}