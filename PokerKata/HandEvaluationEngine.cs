using System.Linq;
using PokerKata.Cards.Values;
using PokerKata.Hands;

namespace PokerKata
{
    public class RoyalFlush : IHandRank
    {
        public int Rank => 10;
        public Hand Hand { get; set; }
    }

    public class NullRank : IHandRank
    {
        public int Rank => 0;
        public Hand Hand { get; set; }
    }

    public interface IHandRank
    {
        int Rank { get; }

        Hand Hand { get; set; }
    }
   
    public interface IRankingEvaluator
    {
        IHandRank Evaluate(Hand hand);
   }

    public class RoyalFlushEvaluator : IRankingEvaluator
    {
        public IHandRank Evaluate(Hand hand)
        {
            var cards = hand.Cards;
            var suitGroups = cards.GroupBy(x => x.Suit).Where(x => x.Count() >= 5);
            foreach (var suitGroup in suitGroups)
            {
                var list = suitGroup.ToList();
                var startIndex = 0;
                while (list.Count - startIndex >= 5)
                {
                    var newList = list.Take(5).ToList();
                    if (
                        newList.TakeWhile(
                            (x, i) =>
                                (i == 0 && newList[i].Value is Ace) ||
                                newList[i].Value.Rank == newList[i - 1].Value.Rank - 1).Count() >= 5)
                    {
                        var bestHand = new Hand();
                        foreach (var card in newList)
                        {
                            bestHand.Add(card);
                        }
                        return new StraightFlush {Hand = bestHand};
                    }
                    startIndex++;
                }
            }
            return new NullRank();
        }
    }

    public class StraightFlushEvaluator : IRankingEvaluator
    {
        public IHandRank Evaluate(Hand hand)
        {
            var cards = hand.Cards;
            var suitGroups = cards.GroupBy(x => x.Suit).Where(x => x.Count() >= 5);
            foreach (var suitGroup in suitGroups)
            {
                var list = suitGroup.ToList();
                var startIndex = 0;
                while (list.Count - startIndex >= 5)
                {
                    var newList = list.Skip(startIndex).Take(5).ToList();
                    if (newList.TakeWhile((x, i) => i == 0 || newList[i].Value.Rank == newList[i - 1].Value.Rank - 1).Count() >= 5)
                    {
                        var bestHand = new Hand();
                        foreach (var card in newList)
                        {
                            bestHand.Add(card);
                        }
                        return new StraightFlush { Hand = bestHand };
                    }
                    startIndex++;
                }

                if (!(list[0].Value is Ace)) continue;

                var lastFour = list.TakeLast(4).ToList();
                if (lastFour[0].Value is Five && lastFour.TakeWhile((card, index) => index == 0 && lastFour[index].Value is Five || (lastFour[index].Value.Rank == lastFour[index - 1].Value.Rank - 1)).Count() == 4)
                {
                    var bestHand = new Hand();
                    bestHand.Add(list[0]);
                    foreach (var card in lastFour)
                    {
                        bestHand.Add(card);
                    }
                    return new RoyalFlush { Hand = bestHand };
                }
            }

            return new NullRank();
        }
    }

    public class StraightFlush : IHandRank
    {
        public int Rank => 9;
        public Hand Hand { get; set; }
    }

    public class FlushEvaluator : IRankingEvaluator
    {
        public virtual IHandRank Evaluate(Hand hand)
        {
            var cards = hand.Cards;
            var suitGroups = cards.GroupBy(x => x.Suit).Where(x => x.Count() >= 5);
            foreach (var suitGroup in suitGroups)
            {
                var bestHand = new Hand();
                foreach (var card in suitGroup.Take(5))
                {
                    bestHand.Add(card);
                }
                return new Flush
                {
                    Hand = bestHand
                };
            }

            return new NullRank();
        }
    }

    public class Flush : IHandRank
    {
        public int Rank => 6;
        public Hand Hand { get; set; }
    }

    public class EvaluationResult 
    {
        public bool Success { get; set; }

        public Hand BestHand { get; set; }
    }

    public class HandEvaluationEngine
    {
        public IHandRank Evaluate(Hand hand)
        {
            return null;
        }
    }

} 