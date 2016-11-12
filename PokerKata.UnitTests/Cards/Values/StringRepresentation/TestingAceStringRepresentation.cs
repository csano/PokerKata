using PokerKata.Cards.Values;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingAceStringRepresentation : TestingStringRepresentation<AceValue>
    {
        protected override string StringRepresentation => "A";
    }
}