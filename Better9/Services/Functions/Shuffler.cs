using System;
namespace Services.Functions
{
	public class Shuffler
	{
		public List<string> shuffleCards { get; private set; }
		private readonly Random random;
		public Shuffler()
		{
			shuffleCards = new List<string>();
			List<string> cards = CreatePlayCards();
			random = new Random();
			ShuffleCards(cards);
		}

        private void ShuffleCards(List<string> cards)
        {
			shuffleCards = cards.OrderBy(s => random.Next()).ToList();
        }

        private List<string> CreatePlayCards()
		{
			List<string> symbols = new List<string> {"Clubs", "Hearts", "Dimonds", "Spades" };
			List<string> cardsCopy = new List<string>();
			string cardName = string.Empty;
			foreach(var name in symbols)
			{
				for(int j=0; j<13; j++)
				{
					cardName = name + (j+1);
					cardsCopy.Add(cardName);

				}
			}
			return cardsCopy;
        }

    }
}

