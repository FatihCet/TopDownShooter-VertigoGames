using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;


namespace TopDownShooter.PlayerCotrols
{
    public class PlayerMovementController : MonoBehaviour
    {

        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Transform _targetTransfrom;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;



        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward * _inputData.Vertical*_playerMovementSettings.verticalSpeed));
            _targetTransfrom.Rotate(0, _inputData.Horizontal * _playerMovementSettings.horizontalSpeed, 0, Space.Self);


        }
    }


}
