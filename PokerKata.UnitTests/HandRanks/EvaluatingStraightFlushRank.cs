using System.Collections.Generic;
using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
using PokerKata.Hands;
using Xunit;

namespace PokerKata.UnitTests.HandRanks
{
    public class EvaluatingStraightFlushRank : EvaluatingRank<StraightFlush>
    {
        [Fact]
        public void ComparingToHigherStraightFlushReturnsOne()
        {
            var hand1Cards = new List<Card>
            {
                new Card(new Ten(), new Heart()),
                new Card(new Nine(), new Heart()),
                new Card(new Eight(), new Heart()),
                new Card(new Seven(), new Heart()),
                new Card(new Six(), new Heart())
            };

            var rank = new StraightFlush { RankedHand = new Hand(hand1Cards) };

            var result = rank.CompareTo(new StraightFlush { RankedHand = CreateHand() });

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ComparingToLowerStraightFlushReturnsNegativeOne()
        {
            var hand2Cards = new List<Card>
            {
                new Card(new Ten(), new Heart()),
                new Card(new Nine(), new Heart()),
                new Card(new Eight(), new Heart()),
                new Card(new Seven(), new Heart()),
                new Card(new Six(), new Heart())
            };

            var rank = new StraightFlush { RankedHand = CreateHand() };

            var result = rank.CompareTo(new StraightFlush { RankedHand = new Hand(hand2Cards) });

            result.ShouldBeEquivalentTo(-1);
        }

        public override IHandRank HandRank => new StraightFlush { RankedHand = CreateHand() };

        private static Hand CreateHand()
        {
            return new Hand(new List<Card>
            {
                new Card(new King(), new Heart()),
                new Card(new Queen(), new Heart()),
                new Card(new Jack(), new Heart()),
                new Card(new Ten(), new Heart()),
                new Card(new Nine(), new Heart())
            });
        }
    }
}