using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests
{
    public class AddingCardsToHand
    {
        [Fact]
        public void AddingSingleCardResultsInSingleCardHand()
        {
            var card = new Card(CardValue.Ace, SuitType.Diamonds);
            var hand = new Hand();

            hand.Add(card);

            hand.ToString().ShouldBeEquivalentTo("Ad");
        }
    }
}
