using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public class PlayerTest
    {
        public float Speed;

        public PlayerTest(float speed)
        {
            Speed = speed;

            Debug.Log($"{typeof(PlayerTest)} speed = {speed}.");
        }
    }
}
