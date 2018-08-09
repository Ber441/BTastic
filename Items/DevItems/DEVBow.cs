using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.DevItems
{
	public class DEVBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DEVBow");
			Tooltip.SetDefault("This is a VERY VERY DAMAGING BOW");
		}
		public override void SetDefaults()
		{
			item.damage = 999999999;
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
			item.shootSpeed = 20f;
			item.autoReuse = true;
			item.useTurn = true;
		}

	}
}