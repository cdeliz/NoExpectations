using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Jest : MonoBehaviour
{
    public Monster boss;
    public Text battleText;
    private UnityAction someListener;
    public string fluffText;
    public int interestStrength = 5;
    public int comfortStrength = 2;
    private int count = 0;

    void Awake()
    {
        someListener = new UnityAction(DoCompliment);
    }
    void OnEnable()
    {
        EventManager.StartListening("jest", someListener);
    }   
    void OnDisable()
    {
        EventManager.StopListening("jest", someListener);
    }
    void DoCompliment()
    {
        if(boss != null)
        {
            if (count == 0)
            {
                Debug.Log("Your joke went really well! The Dragon is very interested.");
                battleText.text = "Your joke went really well! The Dragon is very interested.";
                boss.ChangeInterest(interestStrength);
                boss.ChangeComfort(comfortStrength);
                Debug.Log(boss.interest);
                count++;
            }
            else
            {
                Debug.Log("This would work better if you knew more than one joke.");
                battleText.text = "This would work better if you knew more than one joke.";
            }
        }
    }
}


