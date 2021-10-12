using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {



        [SerializeField] private InputData[] _inputDataArray;
        void Update()
        {
            for (int i = 0; i < _inputDataArray.Length; i++)
            {
                _inputDataArray[i].ProcesInput();
            }
        }
    }


}
