using System;
using DefaultNamespace.GameEvents;
using ScriptableEvents;
using UnityEngine;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;
        [SerializeField] private ScriptableEvent _laserFired;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Shoot();
        }
        
        private void Shoot()
        {
            var trans = transform;
            Instantiate(_laserPrefab, trans.position, trans.rotation);
            _laserFired.Raise();
        }
    }
}
