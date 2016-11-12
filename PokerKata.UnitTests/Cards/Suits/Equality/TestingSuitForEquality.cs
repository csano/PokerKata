using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests.Cards.Suits.Equality
{
    public abstract class TestingSuitForEquality<T> where T: CardSuit, new()
    {
        [Fact]
        public void ReturnsTrueWhenSuitsAreBothHearts()
        {
            var suit1 = new T();
            var suit2 = new T();

            var result = suit1.Equals(suit2);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsTrueWhenSuitIsComparedAgainstItself()
        {
            var suit = new T();

            var result = suit.Equals(suit);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsFalseWhenOneIsHeartsAndTheOtherIsSomethingElse()
        {
            var suit1 = new T();
            var suit2 = new TestCardSuit();

            var result = suit1.Equals(suit2);

            result.Should().BeFalse();
        }
    }
}
