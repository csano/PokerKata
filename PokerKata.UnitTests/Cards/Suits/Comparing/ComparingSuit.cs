using FluentAssertions;
using PokerKata.Cards.Suits;
using Xunit;

namespace PokerKata.UnitTests.Cards.Suits.Comparing
{
    public abstract class ComparingSuit<T> where T: Suit, new()
    {
        [Fact]
        public void ReturnsZeroIfBothAreTheSame()
        {
            var suit = new T();

            var result = suit.CompareTo(suit);

            result.ShouldBeEquivalentTo(0);
        }

        [Fact]
        public void ReturnsValueLessThanOneIfSuitBeingComparedToIsNull()
        {
            var suit = new T();

            var result = suit.CompareTo(null);

            result.Should().BeLessThan(0);
        }

        [Fact]
        public void ReturnValueLessThanZeroIfSuitComesBeforeTheOther()
        {
            var suit1 = new T();
            var suit2 = new TestSuit();

            var result = suit1.CompareTo(suit2);

            result.Should().BeLessThan(0);
        }

        [Fact]
        public void ReturnsValueGreaterThanOneIfSuitIsToFollowSuitBeingComparedTo()
        {
            var suit1 = new TestSuit();
            var suit2 = new T();

            var result = suit1.CompareTo(suit2);

            result.Should().BeGreaterThan(0);
        }
    }
}