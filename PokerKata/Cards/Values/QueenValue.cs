﻿namespace PokerKata.Cards.Values
{
    public class QueenValue : Value
    {
        public override int Rank => 12;

        public override string ToString()
        {
            return "Q";
        }
    }
}