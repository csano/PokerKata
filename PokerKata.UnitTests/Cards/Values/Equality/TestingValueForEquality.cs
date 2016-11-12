using FluentAssertions;
using PokerKata.Cards;
using Xunit;

namespace PokerKata.UnitTests.Cards.Values.Equality
{
    public abstract class TestingValueForEquality<T> where T: Value, new()
    {
        [Fact]
        public void ReturnsTrueWhenValuesAreTheSame()
        {
            var value1 = new T();
            var value2 = new T();

            var result = value1.Equals(value2);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsTrueWhenValueIsComparedAgainstItself()
        {
            var value = new T();

            var result = value.Equals(value);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnsFalseWhenOneIsACertainValueAndTheOtherIsSomethingElse()
        {
            var value1 = new T();
            var value2 = new TestValue();

            var result = value1.Equals(value2);

            result.Should().BeFalse();
        }
    }
}
