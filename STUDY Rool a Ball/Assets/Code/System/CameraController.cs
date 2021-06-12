using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class CameraController :
        MonoBehaviour
    {
        private BasePlayer _player;
        private Vector3 _offset;

        private void Start()
        {
            _player = FindObjectOfType<BasePlayer>();
            _offset = transform.position - _player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = _player.transform.position + _offset;
        }
    }
}
