using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
using Xunit;

namespace PokerKata.UnitTests.Cards
{
    public class CardEquality
    {
        [Fact]
        public void EqualsMethodReturnsFalseIfComparingCardIsNull()
        {
            var card = new Card(new AceValue(), new Club());

            var result = card.Equals(null);

            result.Should().BeFalse();
        }

        [Fact]
        public void EqualsMethodReturnsTrueIfTwoDifferentCardsAreTheSame()
        {
            var card1 = new Card(new AceValue(), new Club());
            var card2 = new Card(new AceValue(), new Club());

            var result = card1.Equals(card2);

            result.Should().BeTrue();
        }

        [Fact]
        public void EqualsMethodReturnsTrueIfACardIsComparedToItself()
        {
            var card = new Card(new AceValue(), new Club());

            var result = card.Equals(card);

            result.Should().BeTrue();
        }

        [Fact]
        public void EqualsMethodReturnsFalseIfTwoCardsAreTheSame()
        {
            var card1 = new Card(new AceValue(), new Club());
            var card2 = new Card(new AceValue(), new Spade());

            var result = card1.Equals(card2);

            result.Should().BeFalse();
        }
    }
}
