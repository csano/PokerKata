using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingNineStringRepresentation : TestingStringRepresentation<NineValue>
    {
        protected override string StringRepresentation => "9";
    }
}