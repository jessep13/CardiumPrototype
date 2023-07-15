using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardiumPrototype
{
	/// <summary>
	/// CardInit initializes the cards used in the game.
	/// </summary>
	internal class CardInit : Initializer
	{
		// Some example cards
		public static readonly Card excalibur = Registry.RegisterCard(new Card(
			"Excalibur",
			Card.CardType.Attack,
			5,
			0,
			7,
			"Requires: 7 or fewer skills left in arsenal"
		));

		public static readonly Card rockShot = Registry.RegisterCard(new Card(
			"Rock Shot",
			Card.CardType.Attack,
			3,
			0,
			4,
			"[Parabola]"
		));

		public static readonly Card psychoBurst = Registry.RegisterCard(new Card(
			"Psycho Burst",
			Card.CardType.Attack,
			7,
			0,
			description: "[Parabola]"
		));

		public static readonly Card psychoShell = Registry.RegisterCard(new Card(
			"Psycho Shell",
			Card.CardType.Defense,
			3,
			0,
			6,
			"[Shelter] Add: Anti-Pierce; protects from damage regardless of STR."
		));
	}
}
