using PokerKata.Cards.Values;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingTenStringRepresentation : TestingStringRepresentation<TenValue>
    {
        protected override string StringRepresentation => "T";
    }
}