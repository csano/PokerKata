using FluentAssertions;
using PokerKata.Cards;
using Xunit;

namespace PokerKata.UnitTests.Cards.Values.Comparing
{
    public abstract class ComparingValue<T> where T: Value, new()
    {
        [Fact]
        public void ReturnsZeroIfBothAreTheSame()
        {
            var value = new T();

            var result = value.CompareTo(value);

            result.ShouldBeEquivalentTo(0);
        }

        [Fact]
        public void ReturnsValueLessThanOneIfValueBeingComparedToIsNull()
        {
            var value = new T();

            var result = value.CompareTo(null);

            result.Should().BeLessThan(0);
        }

        [Fact]
        public void ReturnValueMoreThanZeroIfValueComesBeforeTheOther()
        {
            var value1 = new T();
            var value2 = new TestValue();

            var result = value1.CompareTo(value2);

            result.Should().BeGreaterThan(0);
        }

        [Fact]
        public void ReturnsValueLessThanOneIfValueIsToFollowValueBeingComparedTo()
        {
            var value1 = new TestValue();
            var value2 = new T();

            var result = value1.CompareTo(value2);

            result.Should().BeLessThan(0);
        }
    }
}