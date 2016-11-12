using PokerKata.Cards.Values;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingJackStringRepresentation : TestingStringRepresentation<JackValue>
    {
        protected override string StringRepresentation => "J";
    }
}