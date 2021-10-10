using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lessons
{
    [CreateAssetMenu(menuName ="RigidbodySettings/Settings/Rigidbody")]
    public class RigidbodySettings : ScriptableObject
    {
        [SerializeField] public Vector3 _jumpSpeed;

        public Vector3 JumpSpeed { get { return _jumpSpeed; } }


    }

}
