using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventTriggerButton : MonoBehaviour
{

    public Button triggerButton;
    public string eventToTrigger;

    void Start()
    {
        triggerButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        EventManager.TriggerEvent(eventToTrigger);
    }

}
