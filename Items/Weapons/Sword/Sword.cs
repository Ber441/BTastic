using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.Weapons.Sword
{
	public class Sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sword");
			Tooltip.SetDefault("Pointy Sword");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
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
