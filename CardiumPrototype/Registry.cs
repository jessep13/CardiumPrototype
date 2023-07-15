using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiumPrototype
{
	/// <summary>
	/// Registry maintains a list of objects for the game.
	/// </summary>
	internal static class Registry
	{
		/// <summary>
		/// Cards holds every constructed card made when initializing. 
		/// </summary>
		public static List<Card> Cards = new();

		/// <summary>
		/// Registers a card to the Registry.
		/// </summary>
		/// <param name="card"> The card to be registered. </param>
		/// <returns> The card that was registered. </returns>
		public static Card RegisterCard(Card card)
		{
			Cards.Add(card);
			
			return card;
		}
	}
}
