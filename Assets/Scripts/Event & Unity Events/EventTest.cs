using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public delegate void OnClicked();                   // Delegate Tanimi
    public static event OnClicked OnLeftClicked;        // Eventler 'event' olarak belirlenmelidir.
    public static event OnClicked OnRightClicked;       // OnClicked delegate'sinden bir event nesnesi olusturuldu. 
    public static event OnClicked OnMiddleClicked;    

    private void Start() 
    {
        OnRightClicked += PrintRight;
        OnLeftClicked += PrintLeft;
        OnMiddleClicked += () =>    // Lambda Expression             
        {
            Debug.Log("Mouse Middle Key");
        };
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && OnLeftClicked != null)
            OnLeftClicked();
        
        else if (Input.GetMouseButtonDown(1) && OnRightClicked != null)
            OnRightClicked();
        
        else if (Input.GetMouseButtonDown(2) && OnMiddleClicked != null)
            OnMiddleClicked();
    }

    public void PrintRight()
    {
        print("Right");
    }
    
    public void PrintLeft()
    {
        print("Left");
    }
}

