using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.UI;

public class SomeButton : MonoBehaviour {

    public Button bigButton;

    void OnEnable()
    {
        //Register Button Events
        bigButton.onClick.AddListener(() => buttonCallBack("Hello Affan", 88));
    }

    private void buttonCallBack(string myStringValue, int myIntValue)
    {
        Debug.Log("Button Clicked. Received string: " + myStringValue + " with int: " + myIntValue);
    }

    void OnDisable()
    {
        //Un-Register Button Events
        bigButton.onClick.RemoveAllListeners();
    }
}