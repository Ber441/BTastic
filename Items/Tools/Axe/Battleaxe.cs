using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.Tools.Axe
{
	public class Battleaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Battleaxe");
			Tooltip.SetDefault("Chopping/Killing");
		}
		public override void SetDefaults()
		{
			item.damage = 2000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.axe = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10); //ItemID: IronBar 2, Amount: 10
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(18); //TileID: WorkBenches 18
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}