using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using Xunit;

namespace PokerKata.UnitTests
{
    public class AddingCardsToHand
    {
        [Fact]
        public void AddingNullCardResultsInEmptyStringBeingGenerated()
        {
            var hand = new Hand();

            hand.Add(null);

            hand.ToString().ShouldBeEquivalentTo(string.Empty);
        }

        [Fact]
        public void AddingSingleCardResultsInSingleCardHand()
        {
            var card = new Card(CardValue.Ace, new Diamond());
            var hand = new Hand();

            hand.Add(card);

            hand.ToString().ShouldBeEquivalentTo("Ad");
        }

        [Fact]
        public void AddingTwoCardsResultsInTwoCardHandInOrder()
        {
            var card1 = new Card(CardValue.King, new Diamond());
            var card2 = new Card(CardValue.Ace, new Diamond());
            var hand = new Hand();

            hand.Add(card1);
            hand.Add(card2);

            hand.ToString().ShouldBeEquivalentTo("Ad, Kd");
        }
    }
}
