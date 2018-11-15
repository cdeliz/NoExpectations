using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisplayScreenText : MonoBehaviour
{
    
    private UnityAction someListener;
            
    void Awake()
    {
        someListener = new UnityAction(PrintToTextBox);
    }
    void OnEnable()
    {
        EventManager.StartListening("displayText", someListener);
    }   
    void OnDisable()
    {
        EventManager.StopListening("displayText", someListener);
    }
    void PrintToTextBox()
    {
        Debug.Log("This is where flufftext would go");
        Debug.Log("Paused");
        EventManager.TriggerEvent("pause");
        Debug.Log("Unpaused");
    }
}


