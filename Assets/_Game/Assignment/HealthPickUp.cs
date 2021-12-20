using DefaultNamespace.ScriptableEvents;
using UnityEngine;

namespace Assignment
{
    public class HealthPickUp : MonoBehaviour
    {
        [SerializeField] private ScriptableEventBase _hitByShip;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (string.Equals(other.tag, "Ship"))
            {
                _hitByShip.Raise();
                Destroy(gameObject);
            }
        }

    }
}
