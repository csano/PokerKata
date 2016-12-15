using FluentAssertions;
using Xunit;

namespace PokerKata.UnitTests.HandRanks
{
    public abstract class EvaluatingRank<T> where T: IHandRank, new()
    {
        public abstract IHandRank HandRank { get; }

        [Fact]
        public void ComparingToNullRankReturnsOne()
        {
            var result = HandRank.CompareTo(null);

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ComparingToLowerRankReturnsOne()
        {
            var result = HandRank.CompareTo(new TestRank(HandRank.Rank - 1));

            result.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void ComparingToHigherRankReturnsNegativeOne()
        {
            var result = HandRank.CompareTo(new TestRank(HandRank.Rank + 1));

            result.ShouldBeEquivalentTo(-1);
        }

        [Fact]
        public void ComparingToSelfReturnsZero()
        {
            var result = HandRank.CompareTo(HandRank);

            result.ShouldBeEquivalentTo(0);
        }

        [Fact]
        public void ComparingToSameRankWithSameHandReturnsZero()
        {
            var rank = new T { RankedHand = HandRank.RankedHand };

            var result = rank.CompareTo(new T { RankedHand = HandRank.RankedHand });

            result.ShouldBeEquivalentTo(0);
        }
    }
}