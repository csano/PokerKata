using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingQueenStringRepresentation : TestingStringRepresentation<QueenValue>
    {
        protected override string StringRepresentation => "Q";
    }
}