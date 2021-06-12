using System;
using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    [RequireComponent(typeof(Rigidbody), typeof(SphereCollider))]
    public class BasePlayer :
        MonoBehaviour
    {
        public event Action OnGameOver;
        public event Action OnGameWin;

        public Inventory Inventory { get; private set; }
        public bool CanMove { get; set; } = true;
        public float Speed { get; set; } = 3.0f;


        private Rigidbody _rigidbody;
        private BaseUserInput _userInput;

        private void Awake()
        {
            OnGameOver = () => { };
            OnGameWin = () => { };

            TryGetComponent(out _rigidbody);

            switch (Application.platform)
            {
                case RuntimePlatform.WindowsPlayer:
                case RuntimePlatform.WindowsEditor:
                    _userInput = new PCUserInput("Horizontal", "Vertical");
                    break;
                case RuntimePlatform.IPhonePlayer:
                case RuntimePlatform.Android:
                    //mobile user input
                    break;
                default:
                    throw new System.InvalidOperationException("User input load exception");
            }

            Inventory = new Inventory();
        }

        public void GameOver() => OnGameOver.Invoke();
        protected void Move()
        {
            if (CanMove)
            {
                var x = _userInput.GetHorizontalAxis();
                var z = _userInput.GetVerticalAxis();
                var movement = new Vector3(x, 0.0f, z);
                _rigidbody.AddForce(movement * Speed);
            }
        }
    }
}
