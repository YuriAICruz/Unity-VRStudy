using UnityEngine;

namespace DefaultNamespace
{
    public class Manager : MonoBehaviour
    {
        public InputDemo Input;

        private void Start()
        {
            Input = new InputDemo();
            Input.Init();

            Input.Thumb_L_Axis += PrintAxis;
            Input.Thumb_R_Axis += PrintAxis;
            
            Input.Trigger_L_Axis += PrintTrigger;
            Input.Trigger_R_Axis += PrintTrigger;
        }

        private void PrintTrigger(float axis)
        {
            if(axis <= 0) return;
            
            Debug.Log(":" + axis);
        }

        private void PrintAxis(Vector2 axis)
        {
            if(axis.magnitude <= 0) return;
            
            Debug.Log(":" + axis);
        }
    }
}