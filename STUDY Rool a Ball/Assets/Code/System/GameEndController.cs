using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class GameEndController :
        MonoBehaviour
    {
        [SerializeField] private int _winCount = 100;
        private DisplayGameEnd _displayGameEnd;
        private BasePlayer _player;

        private void Start()
        {
            _displayGameEnd = FindObjectOfType<DisplayGameEnd>();
            _player = FindObjectOfType<BasePlayer>();

            _player.OnGameOver += GameOver;
            _player.OnGameWin += GameWin;
            _player.Inventory.OnCoinsValueChanged += CheckWin;
        }

        public void GameOver()
        {
            _player.CanMove = false;
            _displayGameEnd.DisplayLoose(_player.Inventory.CoinsCount);
        }
        public void GameWin()
        {
            _player.CanMove = false;
            _displayGameEnd.DisplayWin(_player.Inventory.CoinsCount);
        }
        public void CheckWin()
        {
            if (_player.Inventory.CoinsCount >= _winCount) GameWin();
        }
    }
}
