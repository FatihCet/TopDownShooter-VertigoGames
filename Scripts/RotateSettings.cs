using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName ="Rotates/Rotate1/RotateSettings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField]public float _speed = 1f;
        public float Speed { get { return _speed; } }
    }

}


