using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.DevItems
{
	public class DEVBabyAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DEVBabyAxe");
			Tooltip.SetDefault("Much better than a Baby");
		}
		public override void SetDefaults()
		{
			item.damage = 5;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 30;
			item.value = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.axe = 3; 
		}

	}
}