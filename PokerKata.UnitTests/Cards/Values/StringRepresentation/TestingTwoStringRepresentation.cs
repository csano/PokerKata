using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingTwoStringRepresentation : TestingStringRepresentation<Two>
    {
        protected override string StringRepresentation => "2";
    }
}