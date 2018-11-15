using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Compliment : MonoBehaviour
{
    public Monster boss;
    public Text battleText;
    private UnityAction someListener;
    public string fluffText;
    public int interestStrength = 4;

    void Awake()
    {
        someListener = new UnityAction(DoCompliment);
    }
    void OnEnable()
    {
        EventManager.StartListening("compliment", someListener);
    }   
    void OnDisable()
    {
        EventManager.StopListening("compliment", someListener);
    }
    void DoCompliment()
    {
        if (boss != null)
        {
            boss.ChangeInterest(interestStrength);
            battleText.text = PrintText();
            interestStrength /= 2;
        } 
    }

    string PrintText()
    {
        //kill me for this shit code
        if(interestStrength == 4)
        {
            return "The compliments are much appreciated.";
        }
        else if (interestStrength == 2)
        {
            return "The compliments, while a bit heavy now, are still appreciated.";
        }
        else if (interestStrength == 1)
        {
            return "You're really pouring it on, it's starting to wear thin.";
        }

        return "The compliments have officially run their course.";
    }

}


