using Terraria.ID;
using Terraria.ModLoader;
//using BlossomBeloved.

namespace BlossomBeloved
{
    public class Hasta : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shaved Hasta");
            Tooltip.SetDefault("Little spears meant to be shot a short distance");
        }
        public override void SetDefaults()
        {
            item.width = 52;
            item.height = 54;
            item.value = 50;
            item.rare = ItemRarityID.Green;
            item.thrown = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.damage = 11;
            item.crit = 4;
            item.consumable = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.maxStack = 999;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.noUseGraphic = true;
            item.shoot = ModContent.ProjectileType<Projectiles.Thrown.HastaProjectile>();

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Tiles.DireWood.DireWood>(), 10);
            recipe.AddIngredient(ModContent.ItemType<Items.Crafting.TreeBark>());
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    } 
}