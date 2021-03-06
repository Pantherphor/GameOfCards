﻿using Game_Of_Cards.Interfaces;

namespace Game_Of_Cards
{
    public class Dealer : PlayerBase, IPlayer
    {
        public Dealer()
            :this("Dealer")
        {
        }

        public Dealer(string name)
        {
            Name = name;
            Hand = new Hand();
        }

        public string Name { get; private set; }

        public int Score { get => Hand.TotalValue; } 

    }
}