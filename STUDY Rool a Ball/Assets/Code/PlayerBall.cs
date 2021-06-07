using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class PlayerBall :
        Player
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}
