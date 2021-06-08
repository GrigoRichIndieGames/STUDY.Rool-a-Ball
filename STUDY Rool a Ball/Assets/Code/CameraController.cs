using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class CameraController :
        MonoBehaviour
    {
        private Player _player;
        private Vector3 _offset;

        private void Start()
        {
            _player = FindObjectOfType<Player>();
            _offset = transform.position - _player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = _player.transform.position + _offset;
        }
    }
}
