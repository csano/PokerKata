using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using PokerKata.Cards;
using PokerKata.Cards.Values;
using PokerKata.Hands;

namespace PokerKata
{
    public interface IRankingEvaluator
    {

    }

    public class FiveCardHandEvaluator : IRankingEvaluator
    {
        
    }

    public class StraightFlushEvaluator : FlushEvaluator
    {
        public override IEvaluationResult Evaluate(Hand hand)
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
                        return new SuccessEvaulationResult { HighCard = newList.First() };
                    }
                    startIndex++;
                }

                if (!(list[0].Value is Ace)) continue;

                var lastFour = list.TakeLast(4).ToList();
                if (lastFour[0].Value is Five && lastFour.TakeWhile((card, index) => index == 0 && lastFour[index].Value is Five || (lastFour[index].Value.Rank == lastFour[index - 1].Value.Rank - 1)).Count() == 4)
                {
                    return new SuccessEvaulationResult { HighCard = lastFour.First() };
                }
            }

            return new FailureEvaluationResult();
        }
    }

    public class FlushEvaluator : IRankingEvaluator
    {
        public virtual IEvaluationResult Evaluate(Hand hand)
        {
            var cards = hand.Cards;
            var suitGroups = cards.GroupBy(x => x.Suit).Where(x => x.Count() >= 5);
            foreach (var suitGroup in suitGroups)
            {
                return new SuccessEvaulationResult { HighCard = suitGroup.First() };
            }

            return new FailureEvaluationResult();
        }
    }

    public interface IEvaluationResult
    {
        bool Success { get; }
    }

    public class FailureEvaluationResult : IEvaluationResult
    {
        public bool Success => false;
    }

    public class SuccessEvaulationResult : IEvaluationResult
    {
        public bool Success => true;
        
        public Card HighCard { get; set; }
    }

    public class HandEvaluationEngine
    {
        public List<Hand> Evaluate(IEnumerable<Hand> hands)
        {
            return null;
        }
    }
}
