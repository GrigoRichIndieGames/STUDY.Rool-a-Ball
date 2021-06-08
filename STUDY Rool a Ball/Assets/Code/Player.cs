using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    [RequireComponent(typeof(Rigidbody), typeof(SphereCollider))]
    public class Player :
        MonoBehaviour
    {
        public float Speed = 3.0f;

        private Rigidbody _rigidbody;
        private BaseUserInput _userInput;

        private void Start()
        {
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
        }

        protected void Move()
        {
            var x = _userInput.GetHorizontalAxis();
            var z = _userInput.GetVerticalAxis();
            var movement = new Vector3(x, 0.0f, z);
            _rigidbody.AddForce(movement * Speed);
        }
    }
}
