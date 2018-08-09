using Terraria.ModLoader;

namespace BTastic
{
	class BTastic : Mod
	{
		public BTastic()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
