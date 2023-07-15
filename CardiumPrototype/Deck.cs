using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiumPrototype
{
	/// <summary>
	/// A Deck holds a number of cards for the game.
	/// </summary>
	internal class Deck
	{
		/// <summary>
		/// Size represents how large a deck is. All decks are the same size.
		/// </summary>
		public const int size = 30;

		/// <summary>
		/// Private field of Cards
		/// </summary>
		private Card[] cards = new Card[size];

		/// <summary>
		/// Cards represents the cards inside the deck.
		/// </summary>
		public Card[] Cards { get { return cards; } }
	}
}
