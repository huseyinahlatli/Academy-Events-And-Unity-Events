using System;
using UnityEngine;

namespace Events
{
   public class TestingEventSubscriber : MonoBehaviour
   {
      private TestingEvent testingEvent;
      private void Start()
      {
         testingEvent = GetComponent<TestingEvent>();
         testingEvent.OnSpacePressed += TestOnSpacePressed;
      }
      
      private void TestOnSpacePressed(object sender, EventArgs e)
      { 
         Debug.Log("Space!");
         testingEvent.OnSpacePressed -= TestOnSpacePressed;
      }
   }
}