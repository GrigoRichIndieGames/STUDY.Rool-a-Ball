using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class PlayerBall :
        BasePlayer
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}
