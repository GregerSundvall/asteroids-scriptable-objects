using System;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        //[SerializeField] private IntVariable _health;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        [SerializeField] private ScriptableEventBase _healthChanged;
        [SerializeField] private ScriptableEventBase _outOfBounds;
        
        [SerializeField] private IntReference _healthRef;
        [SerializeField] private IntObservable _healthObservable;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                // Debug.Log("Hull collided with Asteroid");
                // TODO can we bake this into one call?
                //_healthRef.ApplyChange(-1);
                //_onHealthChangedEvent.Raise(_healthRef);
                _healthObservable.ApplyChange(-1);
                _healthChanged.Raise();
            }
            

        }

        private void Update()
        {
            CheckBounds();
        }


        void CheckBounds()
        {
            var pos = transform.position;
            var newPos = new Vector3(pos.x, pos.y, pos.z);
            
            if (pos.x > 10)
            {
                newPos.x = -10;
            }
            if (pos.x < -10)
            {
                newPos.x = 10;
            }
            if (pos.y > 6)
            {
                newPos.y = -6;
            }
            if (pos.y < -6)
            {
                newPos.y = 6;
            }

            transform.position = newPos;
            //_outOfBounds.Raise();
        }
    }
}
