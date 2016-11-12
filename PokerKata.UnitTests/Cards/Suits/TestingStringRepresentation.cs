using System.Linq;
using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests.Cards.Suits
{
    public class TestingHeartStringRepresentation: TestingStringRepresentation<Heart> { }
    public class TestingClubStringRepresentation: TestingStringRepresentation<Club> { }
    public class TestingDiamondStringRepresentation: TestingStringRepresentation<Diamond> { }
    public class TestingSpadeStringRepresentation: TestingStringRepresentation<Spade> { }

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