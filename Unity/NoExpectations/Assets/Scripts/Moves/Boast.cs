using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Boast : MonoBehaviour {

    public Player player;
    public Monster boss;
    public Text battleText;
    private UnityAction someListener;
    public string fluffText;
    public int interestStrength;
    private int count = 0;

    void Awake()
    {
        someListener = new UnityAction(DoBoast);
    }
    void OnEnable()
    {
        EventManager.StartListening("boast", someListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("boast", someListener);
    }
    void DoBoast()
    {
        if (boss != null)
        {
            if (count == 0)
            {
                boss.ChangeInterest(1);
                player.confidence += 2;
                Debug.Log("They are mildly interested, you feel empowered.");
                battleText.text = "They are mildly interested, you feel empowered.";
            }
            else
            {
                boss.ChangeComfort(-1);
                Debug.Log("An awkward silence follows your boasting...");
                battleText.text = "An awkward silence follows your boasting...";
            }
            count++;
        }
    }
}
