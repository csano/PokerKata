using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Values.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingAceStringRepresentation : TestingStringRepresentation<AceValue>
    {
        protected override string StringRepresentation => "A";
    }
}