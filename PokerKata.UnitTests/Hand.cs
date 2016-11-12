using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests
{
    public class AddingCardsToHand
    {
        [Fact]
        public void AddingSingleCardResultsInSingleCardHand()
        {
            var card = new Card(CardValue.Ace, new Diamond());
            var hand = new Hand();

            hand.Add(card);

            hand.ToString().ShouldBeEquivalentTo("Ad");
        }
    }
}
