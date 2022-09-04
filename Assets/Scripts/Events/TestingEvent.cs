using System;
using UnityEngine;

namespace Events
{
    public class TestingEvent : MonoBehaviour
    {
        public  event EventHandler OnSpacePressed;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnSpacePressed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
