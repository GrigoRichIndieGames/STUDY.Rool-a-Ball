using System;
using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class Inventory
    {
        public event Action OnCoinsValueChanged;

        public int CoinsCount { get; private set; }


        public Inventory()
        {
            OnCoinsValueChanged = () => { };
        }


        public void AddCoins(int count)
        {
            CoinsCount += count;
            OnCoinsValueChanged.Invoke();
        }
    }
}
