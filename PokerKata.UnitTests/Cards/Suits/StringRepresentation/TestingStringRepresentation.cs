using System.Linq;
using FluentAssertions;
using PokerKata.Cards.Suits;
using Xunit;

namespace PokerKata.UnitTests.Cards.Suits.StringRepresentation
{
    public abstract class TestingStringRepresentation<T> where T: Suit, new()
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