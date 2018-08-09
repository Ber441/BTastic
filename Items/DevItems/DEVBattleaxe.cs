using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.DevItems
{
	public class DEVBattleaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DEVBattleaxe");
			Tooltip.SetDefault("This is a modded Battleaxe");
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


	}
}