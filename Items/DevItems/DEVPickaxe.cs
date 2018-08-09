using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.DevItems
{
	public class DEVPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DEVPickaxe");
			Tooltip.SetDefault("This is a modded Pickaxe.");
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
	}
}