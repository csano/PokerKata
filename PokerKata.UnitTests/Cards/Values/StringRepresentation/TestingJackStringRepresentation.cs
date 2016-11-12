using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingJackStringRepresentation : TestingStringRepresentation<Jack>
    {
        protected override string StringRepresentation => "J";
    }
}