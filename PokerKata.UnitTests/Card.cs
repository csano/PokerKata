using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests
{
    public class ComparingCards
    {
        [Fact]
        public void ReturnsOneIfCardBeingComparedToIsNull()
        {
            var card = new Card(Value.Ace, Suit.Spades);

            var result = card.CompareTo(null);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsOneIfCardBeingComparedToIsLaterInOrderThanCurrentCard()
        {
            var card1 = new Card(Value.King, Suit.Spades);
            var card2 = new Card(Value.Ace, Suit.Spades);

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ReturnsNegativeOneIfCardHasSameValueButSmallerSuitThanTheOther()
        {
            var card1 = new Card(Value.Ace, Suit.Clubs);
            var card2 = new Card(Value.Ace, Suit.Diamonds);

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsNegativeOneIfCardHasLargerValueAndDifferentSuitThanComparingCard()
        {
            var card1 = new Card(Value.Ace, Suit.Clubs);
            var card2 = new Card(Value.King, Suit.Diamonds);

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsNegativeOneIfCardHasLargerValueAndSameSuitThanComparingCard()
        {
            var card1 = new Card(Value.Ace, Suit.Diamonds);
            var card2 = new Card(Value.King, Suit.Diamonds);

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ReturnsOneIfCardHasSameValueButLargerSuitThanTheOther()
        {
            var card1 = new Card(Value.Ace, Suit.Diamonds);
            var card2 = new Card(Value.Ace, Suit.Clubs);

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ReturnsZeroIfCardIsComparedToItself()
        {
            var card = new Card(Value.Ace, Suit.Spades);

            var result = card.CompareTo(card);

            result.ShouldBeEquivalentTo(0);
        }

        [Fact]
        public void ReturnsZeroIfCardIsComparedToOtherCardOfSameSuitAndValue()
        {
            var card1 = new Card(Value.Ace, Suit.Spades);
            var card2 = new Card(Value.Ace, Suit.Spades);

            var result = card1.CompareTo(card2);

            result.ShouldBeEquivalentTo(0);
        }
    }
    public class CardEquality
    {
        [Fact]
        public void EqualsMethodReturnsFalseIfComparingCardIsNull()
        {
            var card = new Card(Value.Ace, Suit.Clubs);

            var result = card.Equals(null);

            result.Should().BeFalse();
        }

        [Fact]
        public void EqualsMethodReturnsTrueIfTwoDifferentCardsAreTheSame()
        {
            var card1 = new Card(Value.Ace, Suit.Clubs);
            var card2 = new Card(Value.Ace, Suit.Clubs);

            var result = card1.Equals(card2);

            result.Should().BeTrue();
        }

        [Fact]
        public void EqualsMethodReturnsTrueIfACardIsComparedToItself()
        {
            var card = new Card(Value.Ace, Suit.Clubs);

            var result = card.Equals(card);

            result.Should().BeTrue();
        }

        [Fact]
        public void EqualsMethodReturnsFalseIfTwoCardsAreTheSame()
        {
            var card1 = new Card(Value.Ace, Suit.Clubs);
            var card2 = new Card(Value.Ace, Suit.Spades);

            var result = card1.Equals(card2);

            result.Should().BeFalse();
        }
    }
}
