using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
using Xunit;

namespace PokerKata.UnitTests.Cards
{
    public class ComparingCards
    {
        [Fact]
        public void ReturnsOneIfCardBeingComparedToIsNull()
        {
            var card = new Card(new Ace(), new Spade());

            var result = card.CompareTo(null);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsOneIfCardBeingComparedToIsLaterInOrderThanCurrentCard()
        {
            var card1 = new Card(new King(), new Spade());
            var card2 = new Card(new Ace(), new Spade());

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ReturnsNegativeOneIfCardHasSameValueButSmallerSuitThanTheOther()
        {
            var card1 = new Card(new Ace(), new Club());
            var card2 = new Card(new Ace(), new Diamond());

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsNegativeOneIfCardHasLargerValueAndDifferentSuitThanComparingCard()
        {
            var card1 = new Card(new Ace(), new Club());
            var card2 = new Card(new King(), new Diamond());

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsNegativeOneIfCardHasLargerValueAndSameSuitThanComparingCard()
        {
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new King(), new Diamond());

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsOneIfCardHasSameValueButLargerSuitThanTheOther()
        {
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new Ace(), new Club());

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ReturnsZeroIfCardIsComparedToItself()
        {
            var card = new Card(new Ace(), new Spade());

            var result = card.CompareTo(card);

            result.ShouldBeEquivalentTo(0);
        }

        [Fact]
        public void ReturnsZeroIfCardIsComparedToOtherCardOfSameSuitAndValue()
        {
            var card1 = new Card(new Ace(), new Spade());
            var card2 = new Card(new Ace(), new Spade());

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(0);
        }
    }
}