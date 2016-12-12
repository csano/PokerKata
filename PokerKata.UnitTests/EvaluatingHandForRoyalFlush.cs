using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
using PokerKata.Hands;
using Xunit;

namespace PokerKata.UnitTests
{
    public class EvaluatingHandForRoyalFlush
    {
        [Fact]
        public void ReturnsFailureResultIfHandIsNotBigEnoughToQualifyForAFlush()
        {
            var hand = new Hand();
            var card = new Card(new Ace(), new Diamond());

            hand.Add(card);

            var result = new RoyalFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<NullRank>();
        }

        [Fact]
        public void ReturnsFailureResultIfHandIsNotAFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new King(), new Diamond());
            var card3 = new Card(new Four(), new Spade());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Two(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new RoyalFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<NullRank>();
        }

        [Fact]
        public void ReturnsFailureResultIfHandIsFlushButNotARoyalFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new King(), new Diamond());
            var card3 = new Card(new Four(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Two(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new RoyalFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<NullRank>();
        }

        [Fact]
        public void ReturnsSuccessIfHandIsRoyalFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new King(), new Diamond());
            var card3 = new Card(new Queen(), new Diamond());
            var card4 = new Card(new Jack(), new Diamond());
            var card5 = new Card(new Ten(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new RoyalFlushEvaluator().Evaluate(hand);

            result.Hand.ShouldBeEquivalentTo("Ad, Kd, Qd, Jd, Td");
        }

        [Fact]
        public void ReturnsSuccessIfHandIsSevenSameSuitedCardsWithRoyalFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new King(), new Diamond());
            var card3 = new Card(new Queen(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Two(), new Diamond());
            var card6 = new Card(new Ten(), new Diamond());
            var card7 = new Card(new Jack(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);
            hand.Add(card6);
            hand.Add(card7);

            var result = new RoyalFlushEvaluator().Evaluate(hand);

            result.Hand.ShouldBeEquivalentTo("Ad, Kd, Qd, Td, Jd");
        }

        [Fact]
        public void ReturnsSuccessIfHandIsSevenMixedCardsWithRoyalFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new King(), new Diamond());
            var card3 = new Card(new Queen(), new Diamond());
            var card4 = new Card(new Three(), new Heart());
            var card5 = new Card(new Two(), new Spade());
            var card6 = new Card(new Ten(), new Diamond());
            var card7 = new Card(new Jack(), new Diamond());


            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);
            hand.Add(card6);
            hand.Add(card7);

            var result = new RoyalFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<EvaluationResult>();
            result.Hand.ShouldBeEquivalentTo("Ad, Kd, Qd, Td, Jd");
        }
    }
}