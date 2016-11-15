using FluentAssertions;
using PokerKata.Cards;
using Xunit;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public abstract class TestingStringRepresentation<T> where T: Value, new()
    {
        protected abstract string StringRepresentation { get; }
            
        [Fact]
        public void ToStringReturnsStringRepresentation()
        {
            var suit = new T();

            var result = suit.ToString();

            result.Should().BeEquivalentTo(StringRepresentation);
        }
    }
}