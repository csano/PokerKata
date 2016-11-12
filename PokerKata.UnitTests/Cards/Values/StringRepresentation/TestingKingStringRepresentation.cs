using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingKingStringRepresentation : TestingStringRepresentation<King>
    {
        protected override string StringRepresentation => "K";
    }
}