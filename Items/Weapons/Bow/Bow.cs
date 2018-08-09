using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.Weapons.Bow
{
	public class Bow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bow");
			Tooltip.SetDefault("Twen Twen");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.noMelee = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 5f;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 2); //ItemID: IronBar 2, Amount: 10
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(18); //TileID: WorkBenches 18
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
