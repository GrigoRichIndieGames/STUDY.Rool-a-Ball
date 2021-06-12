using UnityEngine;
using UnityEngine.UI;


namespace STUDY_Roll_a_Ball
{
    public sealed class DisplayGameEnd :
        MonoBehaviour
    {
        private Image _pnlGameEnd;
        private Text _text;

        private void Start()
        {
            TryGetComponent(out _pnlGameEnd);
            transform.GetChild(0).TryGetComponent(out _text);

            _pnlGameEnd.enabled = false;
            _text.enabled = false;
        }

        public void DisplayWin(int coins)
        {
            _pnlGameEnd.enabled = true;
            _text.enabled = true;
            _text.text = $"ПОБЕДИЛ!!!\nТы набрал: {coins} монет";
        }
        public void DisplayLoose(int coins)
        {
            _pnlGameEnd.enabled = true;
            _text.enabled = true;
            _text.text = $"!!!ПРОИГРАЛ\nТы набрал: {coins} монет";
        }
    }
}
