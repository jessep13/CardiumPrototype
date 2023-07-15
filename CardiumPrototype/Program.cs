using CardiumPrototype;

void PrintCard(Card card)
{
	// All cards have a name and cost
	Console.WriteLine(card.Name);
	Console.WriteLine($"Cost: {card.Cost}");
	Console.WriteLine($"Uses: {(card.Use <= 0 ? "∞" : card.Use)}");
	Console.WriteLine(((card.Type == Card.CardType.Attack || card.Type == Card.CardType.Defense) ? $"Power: {card.Power}" : ""));
	Console.WriteLine(card.Description);
}

if (CardInit.excalibur == null) return;

Console.WriteLine($"Total Cards: {Registry.Cards.Count}");

foreach (Card card in Registry.Cards)
{
	PrintCard(card);
}

Console.ReadKey();