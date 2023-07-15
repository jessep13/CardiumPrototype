using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiumPrototype
{
	internal class Card
	{
		/// <summary>
		/// CardType categories the main effect types of the cards.
		/// </summary>
		enum CardType
		{
			/// <summary>
			/// Energy cards increase the maximum energy the user can hold.
			/// </summary>
			Energy,

			/// <summary>
			/// Attack cards deal damage to the target.
			/// </summary>
			Attack,

			/// <summary>
			/// Defense cards block incoming attacks when used. They break when the attack power is higher than the defense power.
			/// </summary>
			Defense,

			/// <summary>
			/// Erase cards will remove cards, statuses, enviromentals, and/or other effects from the target.
			/// </summary>
			Erase,

			/// <summary>
			/// Status cards change the stats of the target.
			/// </summary>
			Status,

			/// <summary>
			/// Special cards have a variety of effects that may not fit into other categories.
			/// </summary>
			Special,

			/// <summary>
			/// Enviromental cards, when placed, affect the entire match while active.
			/// </summary>
			Enviromental
		}

		/// <summary>
		/// Type represents the kind of card this effect belongs to.
		/// </summary>
		private readonly CardType type;

		/// <summary>
		/// Cost represents the amount of energy needed to play the card.
		/// </summary>
		private readonly int cost;

		/// <summary>
		/// Power represents damage for attack, and protection for defense. Unused for other types of skills.
		/// </summary>
		private readonly int power;

		/// <summary>
		/// Use represents the number of times a skill can be used. Set this to 0 or below to allow for the skill to be infinitely used.
		/// </summary>
		private readonly int use;

		/// <summary>
		/// Description states the additional information about the card. Can be set to null to have no additonal description.
		/// </summary>
		private readonly string? description;
	}
}
