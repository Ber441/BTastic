using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.DevItems
{
	public class DEVSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DEVSword");
			Tooltip.SetDefault("This is a VERY VERY DAMAGING SWORD");
		}
		public override void SetDefaults()
		{
			item.damage = 999999999;
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

	}
}
