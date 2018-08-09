using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.Tools.Pickaxe
{
	public class Pickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pickaxe");
			Tooltip.SetDefault("Higher than other pickaxes");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 11; // Lower the Faster // Higher the Slow 
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.pick = 65;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 10); //ItemID: Emerald 179, Amount: 10
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(18); //TileID: WorkBenches 18
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}