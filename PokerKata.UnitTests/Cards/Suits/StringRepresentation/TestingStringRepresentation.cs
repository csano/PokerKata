using System.Linq;
using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests.Cards.Suits.StringRepresentation
{
    public abstract class TestingStringRepresentation<T> where T: CardSuit, new()
    {
        [Fact]
        public void ToStringReturnsFirstCharacterOfSuitName()
        {
            var suit = new T();

            var result = suit.ToString();

            result.Should().BeEquivalentTo(suit.GetType().Name.ToCharArray().First().ToString().ToLower());
        }
    }
}