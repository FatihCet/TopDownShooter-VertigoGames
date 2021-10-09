using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{

    public class RigidbodyController : MonoBehaviour
    {

        [SerializeField] private Rigidbody _ribi;
        [SerializeField]RigidbodySettings rigidbodySettings;

        private void Update()
        {
            bool spaceKeyDown= Input.GetKeyDown(KeyCode.Space);

            if (spaceKeyDown == true)
            {
                _ribi.AddForce(rigidbodySettings.JumpForce, ForceMode.Impulse);
                Debug.Log("Havaya zıpladı");
            }

        }



    }


}

