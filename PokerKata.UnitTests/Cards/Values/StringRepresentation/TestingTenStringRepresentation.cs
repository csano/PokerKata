using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingTenStringRepresentation : TestingStringRepresentation<TenValue>
    {
        protected override string StringRepresentation => "T";
    }
}