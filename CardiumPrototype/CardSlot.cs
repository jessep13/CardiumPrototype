using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiumPrototype
{
	internal class CardSlot
	{
		/// <summary>
		/// Card is the current card in the slot. Can be set to null to be empty.
		/// </summary>
		private Card? card;

		/// <summary>
		/// Uses counts the number of times a card has been used while in the slot.
		/// </summary>
		private int uses = 0;

		/// <summary>
		/// Determines whether or not the card is used up or not from repeated uses.
		/// </summary>
		/// <returns> Return True if the card is in the slot, it is not infinite use, and has been used the maximum amount of times </returns>
		public bool IsExpired() => card != null && card.Use > 0 && uses >= card.Use;

		/// <summary>
		/// Activate will use the card. It will remove the card if it is used up.
		/// </summary>
		public void Activate()
		{
			// If our slot is empty, don't activate the card
			if (card == null) return;
			
			// TODO: Add code to trigger the card.

			// Increase the uses.
			uses++;

			// Check if the card should be removed.
			if (IsExpired())
			{
				card = null;
				uses = 0;
			}
		}
	}
}
