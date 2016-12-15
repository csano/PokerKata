using System;
using PokerKata.Hands;

namespace PokerKata.UnitTests.HandRanks
{
    public class TestRank : IHandRank
    {
        public TestRank(int rank)
        {
            Rank = rank;
        }

        public int CompareTo(IHandRank other)
        {
            throw new NotImplementedException();
        }

        public int Rank { get; }
        public Hand RankedHand { get; set; }
    }
}