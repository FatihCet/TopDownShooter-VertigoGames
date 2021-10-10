using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName ="TopDownShooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {

        public float horizontalSpeed = 5f;
        public float verticalSpeed = 5f;


    }

}

