using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisablePlayerInput : MonoBehaviour
{
    private UnityAction disableInputListener;
    private string listenKey = "disable";
    public GameObject movesList;

    void Awake()
    {
        disableInputListener = new UnityAction(DisableInput);
    }
    void OnEnable()
    {
        EventManager.StartListening(listenKey, disableInputListener);
    }
    void OnDisable()
    {
        EventManager.StopListening(listenKey, disableInputListener);
    }
    void DisableInput()
    {
        movesList.SetActive(false);
        Debug.Log("Waiting");
        PauseOneSecond();
        Debug.Log("Not Waiting");
    }

    void PauseOneSecond()
    {
        StartCoroutine(StopTime());
    }

    IEnumerator StopTime()
    {
        yield return new WaitForSeconds(1);
        movesList.SetActive(true);
    }


}


