﻿using System.Collections.Generic;
using System.Linq;
using PokerKata.Cards;

namespace PokerKata.Hands
{
    public class Hand
    {
        public LinkedList<Card> Cards { get; }

        public Hand()
        {
            Cards = new LinkedList<Card>();
        }

        public Hand(List<Card> cards) : this()
        {
            if (cards != null)
            {
                foreach (var card in cards)
                {
                    Add(card);
                }
            }
        }

        public virtual void Add(Card cardToAdd)
        {
            if (cardToAdd == null)
            {
                return;
            }

            var current = Cards.First;
            while (current != null)
            {
                if (cardToAdd.CompareTo(current.Value) < 0)
                {
                    Cards.AddBefore(current, cardToAdd);
                    return;
                }
                current = current.Next;
            }
            Cards.AddLast(cardToAdd);
        }

        public override string ToString()
        {
            return string.Join(", ", Cards.Select(card => $"{card.Value}{card.Suit}").ToArray());
        }
    }
}
