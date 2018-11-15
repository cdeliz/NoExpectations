using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseGame : MonoBehaviour
{
    private UnityAction pauseListener;
    
    void Awake()
    {
        pauseListener = new UnityAction(PauseOneSecond);
    }
    void OnEnable()
    {
        EventManager.StartListening("pause", pauseListener);
    }   
    void OnDisable()
    {
        EventManager.StopListening("pause", pauseListener);
    }
    void PauseOneSecond()
    {
        StartCoroutine(StopTime());
    }

    IEnumerator StopTime()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(1);
        Debug.Log(Time.time);
    }
}