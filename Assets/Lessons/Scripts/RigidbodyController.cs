using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RigidbodyController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidbodySettings _rigidbodySettings;

        void Update()
        {
            bool jumpForce = Input.GetKeyDown(KeyCode.Space);
            if (jumpForce == true)
            {
                _rigidbody.AddForce(_rigidbodySettings._jumpSpeed, ForceMode.Impulse);

            }

        }
    }


}

