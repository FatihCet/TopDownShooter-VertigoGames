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
        public string AxisNameHorizontal;
        public string AxisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _KeyBaseHorizontalActive;
        public KeyCode PositiveHorizontalKeycode;
        public KeyCode NegativeHorizontalKeycode;
        public float LerpSpeed = 1;
        [SerializeField] private bool _KeyBaseVerticalActive;
        public KeyCode PositiveVerticalKeyCode;
        public KeyCode NegativeVerticalKeycode;


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
                    bool positiveActive = Input.GetKey(PositiveHorizontalKeycode);
                    bool negativeActive = Input.GetKey(NegativeHorizontalKeycode);
                    if (positiveActive && negativeActive)
                    {
                        Horizontal = Mathf.Lerp(Horizontal, 1, Time.time * LerpSpeed);

                    }
                    else if(negativeActive && !positiveActive)
                    {

                        Horizontal = Mathf.Lerp(Horizontal, 1, Time.time * LerpSpeed);
                    }
                    else
                    {
                        Horizontal = Mathf.Lerp(Horizontal, 0, Time.time * LerpSpeed);
                    }
                }
                if (_KeyBaseVerticalActive)
                {

                }

            }
        }

        public void KeyBaseHorizontal(ref float value,KeyCode positive,KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);
            if (positiveActive && negativeActive)
            {
                Horizontal = Mathf.Lerp(Horizontal, 1, Time.time * LerpSpeed);

            }
            else if (negativeActive && !positiveActive)
            {

                Horizontal = Mathf.Lerp(Horizontal, 1, Time.time * LerpSpeed);
            }
            else
            {
                Horizontal = Mathf.Lerp(Horizontal, 0, Time.time * LerpSpeed);
            }
        }


    }
}

