using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateScripts : MonoBehaviour
    {
        [SerializeField]private RotateSettings _rotateSettings;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up * _rotateSettings.Speed * Time.deltaTime);
        }
    }
}
