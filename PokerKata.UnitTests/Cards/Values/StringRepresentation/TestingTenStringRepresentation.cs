using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingTenStringRepresentation : TestingStringRepresentation<Ten>
    {
        protected override string StringRepresentation => "T";
    }
}