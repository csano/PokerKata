using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Suits;
using PokerKata.Cards.Values;
using PokerKata.Hands;
using Xunit;

namespace PokerKata.UnitTests
{
    public class EvaluatingHandForStraightFlush
    {
        [Fact]
        public void ReturnsFailureResultIfHandIsNotBigEnoughToQualifyForAFlush()
        {
            var hand = new Hand();
            var card = new Card(new Ace(), new Diamond());

            hand.Add(card);

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<FailureEvaluationResult>();
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

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<FailureEvaluationResult>();
        }

        [Fact]
        public void ReturnsFailureResultIfHandIsFlushButNotAStraightFlush()
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

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<FailureEvaluationResult>();
        }

        [Fact]
        public void ReturnsSuccessIfHandIsAceHighStraightFlush()
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

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card1);
        }

        [Fact]
        public void ReturnsSuccessIfHandIsFiveHighStraightFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new Five(), new Diamond());
            var card3 = new Card(new Four(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Two(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card2);
        }


        [Fact]
        public void ReturnsSuccessIfHandIsSevenCardsWithFiveHighStraightFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new Five(), new Diamond());
            var card3 = new Card(new Four(), new Diamond());
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

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card2);
        }

        [Fact]
        public void ReturnsFailureIfHandIs6543AFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new Six(), new Diamond());
            var card3 = new Card(new Five(), new Diamond());
            var card4 = new Card(new Four(), new Diamond());
            var card5 = new Card(new Three(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<FailureEvaluationResult>();
        }

        [Fact]
        public void ReturnsSuccessIfHandIsSevenHighStraightlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Seven(), new Diamond());
            var card2 = new Card(new Five(), new Diamond());
            var card3 = new Card(new Four(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Six(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card1);
        }

        [Fact]
        public void ReturnsSuccessIfHandIsSevenHighStraightFlushWithTwoRandomHigherCards()
        {
            var hand = new Hand();
            var card1 = new Card(new Seven(), new Diamond());
            var card2 = new Card(new Five(), new Diamond());
            var card3 = new Card(new Four(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Six(), new Diamond());
            var card6 = new Card(new Ace(), new Diamond());
            var card7 = new Card(new Jack(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);
            hand.Add(card6);
            hand.Add(card7);

            var result = new StraightFlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card1);
        }

    }

    public class EvaluatingHandForFlush
    {
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

            var result = new FlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<FailureEvaluationResult>();
        }


        [Fact]
        public void ReturnsSuccessResultIfHandIsAFlush()
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

            var result = new FlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
        }

        [Fact]
        public void ReturnsSuccessIfFiveCardHandIsFiveHighFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Diamond());
            var card2 = new Card(new Five(), new Diamond());
            var card3 = new Card(new Four(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Two(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);

            var result = new FlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card1);
        }

        [Fact]
        public void ReturnsSuccessResultIfSevenCardHandIsAFlush()
        {
            var hand = new Hand();
            var card1 = new Card(new Ace(), new Club());
            var card2 = new Card(new King(), new Club());
            var card3 = new Card(new Seven(), new Diamond());
            var card4 = new Card(new Three(), new Diamond());
            var card5 = new Card(new Two(), new Diamond());
            var card6 = new Card(new Ace(), new Diamond());
            var card7 = new Card(new King(), new Diamond());

            hand.Add(card1);
            hand.Add(card2);
            hand.Add(card3);
            hand.Add(card4);
            hand.Add(card5);
            hand.Add(card6);
            hand.Add(card7);

            var result = new FlushEvaluator().Evaluate(hand);

            result.Should().BeOfType<SuccessEvaulationResult>();
            ((SuccessEvaulationResult)result).HighCard.ShouldBeEquivalentTo(card6);
        }
    }
}
