using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Perform : MonoBehaviour
{
    //shit code section
    public Player player;
    public Monster boss;
    public Text battleText;
    private UnityAction someListener;
    public string fluffText;
    public int interestStrength;
    private int count = 0;

    void Awake()
    {
        someListener = new UnityAction(DoPerform);
    }
    void OnEnable()
    {
        EventManager.StartListening("perform", someListener);
    }   
    void OnDisable()
    {
        EventManager.StopListening("perform", someListener);
    }
    void DoPerform()
    {
        if(boss != null)
        {
            if (count > 0)
            {
                interestStrength = (int)(1.2 * player.confidence)/count;
                boss.ChangeInterest(interestStrength);
                battleText.text = "It isn't so impressive anymore.";
                Debug.Log("It isn't so impressive anymore.");
                Debug.Log(boss.interest);
            }
            else
            {
                interestStrength = (int)(1.2 * player.confidence);
                boss.ChangeInterest(interestStrength);
                battleText.text = "Your moves were pretty impressive.";
                Debug.Log("Your moves were pretty impressive.");
                Debug.Log(boss.interest);
            }

            count++;
        }
    }
}


