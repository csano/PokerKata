using FluentAssertions;
using PokerKata.Cards.Suits;
using Xunit;

namespace PokerKata.UnitTests.Cards.Suits.Equality
{
    public abstract class TestingSuitForEquality<T> where T: Suit, new()
    {
        [Fact]
        public void ReturnsTrueWhenSuitsAreBothTheSame()
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
        public void ReturnsFalseWhenOneIsACertainValueAndTheOtherIsSomethingElse()
        {
            var suit1 = new T();
            var suit2 = new TestSuit();

            var result = suit1.Equals(suit2);

            result.Should().BeFalse();
        }
    }
}
