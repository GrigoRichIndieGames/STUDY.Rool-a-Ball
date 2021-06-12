using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class EndGameBadBonus :
        BaseInteractableObject,
        IRotator,
        IFlyer
    {
        private float _lenghtFlay;
        private float _speedRotation;

        private void Awake()
        {
            _lenghtFlay = Random.Range(1.0f, 1.5f);
            _speedRotation = Random.Range(10.0f, 50.0f);
        }


        protected override void Interact(BasePlayer player)
        {
            player.GameOver();
        }


        public void Flay() => transform.localPosition = new Vector3(transform.localPosition.x, MIN_HEIGHT + Mathf.PingPong(Time.time, _lenghtFlay), transform.localPosition.z);
        public void Rotate() => transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
    }
}
