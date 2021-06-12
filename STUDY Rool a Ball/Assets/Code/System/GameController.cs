using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class GameController :
        MonoBehaviour
    {
        private BaseInteractableObject[] _interactiveObjects;

        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<BaseInteractableObject>();

        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                if (_interactiveObjects[i] == null) continue;
                if (_interactiveObjects[i] is IFlyer flay) flay.Flay();
                if (_interactiveObjects[i] is IFlicker flicker) flicker.Flick();
                if (_interactiveObjects[i] is IRotator rotation) rotation.Rotate();
            }
        }
    }
}
