using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;

public class UnityEventTest : MonoBehaviour
{
     [Serializable] public class OnClicked : UnityEvent { }

     public OnClicked onLeftClicked;
     public OnClicked onRightClicked;

     private void Start()
     {    
          onRightClicked.AddListener(PrintRight);
          onLeftClicked.AddListener(PrintLeft);
     }

     private void Update()
     {
          if (Input.GetMouseButtonDown(0))
          {
               if (onLeftClicked != null)
               {
                    onLeftClicked.Invoke();
               }
          }
          else if (Input.GetMouseButtonDown(1))
          {
               onRightClicked?.Invoke(); // < ? > means of onLeftClicked != null
          }
     }
     
     private void PrintRight()
     {
          print("Right");
     }

     private void PrintLeft()
     {
          print("Left");
     }
}
