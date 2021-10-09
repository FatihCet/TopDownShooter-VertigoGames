using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName ="Control Rigidbodys/RigidbodysSettings/Settings")]
    public class RigidbodySettings : ScriptableObject
    {

        [SerializeField] private Vector3 _jumpForce;

        public Vector3 JumpForce { get { return _jumpForce; } }



    }

}

