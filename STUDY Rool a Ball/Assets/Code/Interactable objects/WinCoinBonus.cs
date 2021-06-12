using UnityEngine;
using static UnityEngine.Mathf;
using static UnityEngine.Random;
using static UnityEngine.Time;



namespace STUDY_Roll_a_Ball
{
    public sealed class WinCoinBonus :
        BaseInteractableObject,
        IFlicker,
        IFlyer,
        IRotator
    {
        [SerializeField] private int _reward = 5;

        private Material _material;
        private float _lenghtFlay;
        private float _speedRotation;


        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lenghtFlay = Range(1.0f, 1.5f);
            _speedRotation = Range(10.0f, 90.0f);
        }


        protected override void Interact(BasePlayer player) => player.Inventory.AddCoins(_reward);


        public void Flick() => _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, PingPong(time, 1.0f));
        public void Flay() => transform.localPosition = new Vector3(transform.localPosition.x, MIN_HEIGHT + PingPong(time, _lenghtFlay), transform.localPosition.z);
        public void Rotate() => transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
