using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public abstract class BaseInteractableObject :
        MonoBehaviour
    {
        protected const float MIN_HEIGHT = 0.5f;

        public bool IsInteractable { get; } = true;


        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player")) return;
            other.TryGetComponent(out BasePlayer player);
            Interact(player);
            Destroy(gameObject);
        }


        protected abstract void Interact(BasePlayer player);
    }
}
