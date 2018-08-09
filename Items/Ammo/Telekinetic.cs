using Terraria.ID;
using Terraria.ModLoader;
//using Terraria.ModLoader.ModTile;
//using Weapons.Items.WorkBenches;
//using Weapons.Items.Ammo;

namespace BTastic.Items.Ammo
{
	public class Telekinetic : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Telekinetic");
			Tooltip.SetDefault("Splits in to different arrows");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = 1;
			item.rare = 1;
			item.shoot = mod.ProjectileType("ArrownameProj");
			item.shootSpeed = 2f;
			item.ammo = 40; //Arrow = 40
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddIngredient(40, 3);
			recipe.AddTile(18);
			//recipe.AddTile(null, "ArrowMakerTileID");
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	
	}

}
