using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;


namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {

        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;



        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward * _inputData.vertical*_playerMovementSettings.verticalSpeed));
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.right * _inputData.horizontal*_playerMovementSettings.horizontalSpeed));


        }
    }


}
