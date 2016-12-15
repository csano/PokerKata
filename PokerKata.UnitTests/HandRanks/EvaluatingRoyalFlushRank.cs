using System.Collections.Generic;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
using PokerKata.Hands;

namespace PokerKata.UnitTests.HandRanks
{
    public class EvaluatingRoyalFlushRank : EvaluatingRank<RoyalFlush>
    {
        public override IHandRank HandRank => new RoyalFlush { RankedHand = CreateHand() };

        private static Hand CreateHand()
        {
            return new Hand(new List<Card>
            {
                new Card(new Ace(), new Heart()),
                new Card(new King(), new Heart()),
                new Card(new Queen(), new Heart()),
                new Card(new Jack(), new Heart()),
                new Card(new Ten(), new Heart())
            });
        }
    }
}
