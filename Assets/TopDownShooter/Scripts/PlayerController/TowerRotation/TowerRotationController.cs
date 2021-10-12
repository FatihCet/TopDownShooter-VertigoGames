using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;

namespace TopDownShooter.PlayerCotrols
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _rotationInput;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] TowerRotationSettings _towerRotationSpeed;

        private void Update()
        {

            _towerTransform.Rotate(0, _rotationInput.Horizontal*_towerRotationSpeed.towerRotationSpeed, 0, Space.Self);
        }

    }

}

