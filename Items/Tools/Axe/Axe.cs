using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.Tools.Axe
{
	public class Axe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Axe");
			Tooltip.SetDefault("Much better than a Baby Axe.");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.axe = 8; 
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 10); //ItemID: Emerald 179, Amount: 10
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(18); //TileID: WorkBenches 18
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}