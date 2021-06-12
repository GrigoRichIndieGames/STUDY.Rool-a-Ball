using UnityEngine;
using UnityEngine.UI;


namespace STUDY_Roll_a_Ball
{
    public sealed class DisplayCoins :
        MonoBehaviour
    {
        private Text _text;
        private BasePlayer _player;

        private void Start()
        {
            TryGetComponent(out _text);
            _player = FindObjectOfType<BasePlayer>();
            _player.Inventory.OnCoinsValueChanged += Display;

            Display();
        }

        public void Display()
        {
            _text.text = $"Вы набрали: {_player.Inventory.CoinsCount} монет";
        }

    }
}
