using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName ="TopDownShooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;

        [Header("Axis Base Controller")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _KeyBaseHorizontalActive;
        [SerializeField]private KeyCode PositiveHorizontalKeycode;
        [SerializeField] private KeyCode NegativeHorizontalKeycode;
        [SerializeField] private float _increaseAmound = 0.015f;
        [SerializeField] private bool _KeyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVerticalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeycode;


        public void ProcesInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(AxisNameHorizontal);
                Vertical = Input.GetAxis(AxisNameVertical);

            }
            else
            {
                if (_KeyBaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref Horizontal, PositiveHorizontalKeycode, NegativeHorizontalKeycode);
                    
                }
                if (_KeyBaseVerticalActive)
                {
                    KeyBaseAxisControl(ref Vertical, PositiveVerticalKeyCode, NegativeVerticalKeycode);
                }

            }
        }

        public void KeyBaseAxisControl(ref float value,KeyCode positive,KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);
            if (positiveActive)
            {
                value = +_increaseAmound;

            }
            else if (negativeActive)
            {

                value = -_increaseAmound;
            }
            else
            {
                value = 0;
            }

            value = Mathf.Clamp(value,-1,1);
        }


    }
}

