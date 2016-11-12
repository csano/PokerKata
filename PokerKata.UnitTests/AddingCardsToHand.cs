using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
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
            var card = new Card(new Ace(), new Diamond());
            var hand = new Hand();

            hand.Add(card);

            hand.ToString().ShouldBeEquivalentTo("Ad");
        }

        [Fact]
        public void AddingTwoCardsResultsInTwoCardHandInOrder()
        {
            var card1 = new Card(new King(), new Diamond());
            var card2 = new Card(new Ace(), new Diamond());
            var hand = new Hand();

            hand.Add(card1);
            hand.Add(card2);

            hand.ToString().ShouldBeEquivalentTo("Ad, Kd");
        }

        [Fact]
        public void AddingMixedCardsResultsInHandBeingInExpectedOrder()
        {
            var card1 = new Card(new King(), new Diamond());
            var card2 = new Card(new Ace(), new Diamond());
            var card3 = new Card(new Ace(), new Club());
            var card4 = new Card(new Two(), new Heart());
            var hand = new Hand();

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);

            hand.ToString().ShouldBeEquivalentTo("Ac, Ad, Kd, 2h");
        }

        [Fact]
        public void AddingAllFourAcesResultsInAcesBeingListedInOrder()
        {
            var card1 = new Card(new Ace(), new Spade());
            var card2 = new Card(new Ace(), new Diamond());
            var card3 = new Card(new Ace(), new Club());
            var card4 = new Card(new Ace(), new Heart());
            var hand = new Hand();

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);

            hand.ToString().ShouldBeEquivalentTo("Ac, Ad, Ah, As");
        }
    }
}
