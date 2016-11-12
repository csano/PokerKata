using PokerKata.Cards;

namespace PokerKata
{
    public abstract class HandWithLimitOfCards : Hand
    {
        public abstract int MaxCardCount { get; }
        private int countOfCards;

        public override void Add(Card cardToAdd)
        {
            if (countOfCards == MaxCardCount)
            {
                throw new HandIsFullException();
            }
            base.Add(cardToAdd);

            if (cardToAdd != null)
            {
                countOfCards++;
            }
        }
    }
}