using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class PlayerBallTest :
        PlayerTest
    {
        public PlayerBallTest(float speed) : base(speed)
        {
            Debug.Log($"{typeof(PlayerBallTest)} speed = {speed}");
        }
    }
}
