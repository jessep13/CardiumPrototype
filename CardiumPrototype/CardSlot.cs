using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiumPrototype
{
	/// <summary>
	/// HandSlot represents a card that is in the player's hand.
	/// </summary>
	internal class HandSlot
	{
		/// <summary>
		/// Private field of CurrCard
		/// </summary>
		private Card? _currCard;
		
		/// <summary>
		/// CurrCard is the current card in the slot. Can be set to null to be empty.
		/// </summary>
		public Card? CurrCard { get { return _currCard; } }

		/// <summary>
		/// Private field of Uses
		/// </summary>
		private int _uses;

		/// <summary>
		/// Uses counts the number of times a card has been used while in the slot.
		/// </summary>
		public int Uses { get { return _uses; } }

		/// <summary>
		/// Determines whether or not the card is used up or not from repeated uses.
		/// </summary>
		/// <returns> Return True if the card is in the slot, it is not infinite use, and has been used the maximum amount of times </returns>
		public bool IsExpired() => CurrCard != null && CurrCard.Use > 0 && Uses >= CurrCard.Use;

		/// <summary>
		/// Activate will use the card. It will remove the card if it is used up.
		/// </summary>
		public void Activate()
		{
			// If our slot is empty, don't activate the card.
			if (_currCard == null) return;

			// Trigger the card
			_currCard.Action();

			// Increase the uses.
			_uses++;

			// Check if the card should be removed.
			if (IsExpired())
			{
				_currCard = null;
				_uses = 0;
			}
		}
	}
}
