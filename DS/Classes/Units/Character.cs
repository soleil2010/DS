using System.Collections.Generic;
using System.Numerics;

namespace DS
{
	public abstract class Character
    {
        public Vector2 Location {get; set;}
		public Stats CurrentStats {get; protected set; }
		public Stats FinalStats {get; protected set; }
		public List<Item> Inventory { get; protected set; }

		public Weapon Weapon { get; set; }

		public Character(Stats stats)
		{
			Inventory = new List<Item>();
			Location = Vector2.Zero;
			CurrentStats = FinalStats = stats;
		}
		
		public Character(Stats stats, Vector2 location)
		{
			Location = location;
			CurrentStats = FinalStats = stats;
		}

		public Stats Attack(Character character)
		{
			Stats damages = Stats.Zero();
			if (Weapon == null)
				return damages;

			damages.Attack = character.CurrentStats.Defense - Weapon.Stats.Attack;
			damages.Magic = character.CurrentStats.Resistance - Weapon.Stats.Magic;

			//positive damage (physical or magical) means that the opponent has blocked everything 
			damages.Attack = damages.Attack >= 0 ? 0 : -damages.Attack;
			damages.Magic = damages.Magic >= 0 ? 0 : -damages.Attack;
			
			return damages;
		}
    }
}
