using Terraria.ID;
using Terraria.ModLoader;

namespace BTastic.Items.DevItems
{
	public class DEVStupidHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DEVStupid Hammer");
			Tooltip.SetDefault("Hi I am Stupid Hammer. I am here just to be here!");
		}
		public override void SetDefaults()
		{
			item.damage = 0; // Damage
			item.melee = false; // Hitting Power
			item.width = 40; //Position
			item.height = 40; //Position
			item.useTime = 20; // Item Used
			item.useAnimation = 20; // Animations
			item.useStyle = 2;
			item.knockBack = 0; // Knockback
			item.value = 1; // Rare
			item.rare = 1; // Rarity
			item.UseSound = SoundID.Item1; //Sound
			item.autoReuse = true; // Reused in the Game
			item.useTurn = true;
			item.hammer = 1; // Hammer Power
		}

	}
}