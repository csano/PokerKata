using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests
{
    public class CardEquality
    {
        [Fact]
        public void EqualsMethodReturnsFalseIfComparingCardIsNull()
        {
            var card = new Card(CardValue.Ace, SuitType.Clubs);

            var result = card.Equals(null);

            result.Should().BeFalse();
        }

        [Fact]
        public void EqualsMethodReturnsTrueIfTwoDifferentCardsAreTheSame()
        {
            var card1 = new Card(CardValue.Ace, SuitType.Clubs);
            var card2 = new Card(CardValue.Ace, SuitType.Clubs);

            var result = card1.Equals(card2);

            result.Should().BeTrue();
        }

        [Fact]
        public void EqualsMethodReturnsTrueIfACardIsComparedToItself()
        {
            var card = new Card(CardValue.Ace, SuitType.Clubs);

            var result = card.Equals(card);

            result.Should().BeTrue();
        }

        [Fact]
        public void EqualsMethodReturnsFalseIfTwoCardsAreTheSame()
        {
            var card1 = new Card(CardValue.Ace, SuitType.Clubs);
            var card2 = new Card(CardValue.Ace, SuitType.Spades);

            var result = card1.Equals(card2);

            result.Should().BeFalse();
        }
    }
}
