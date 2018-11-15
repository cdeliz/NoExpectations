using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    private int goalInterest = 10;
    private int startInterest = 0;
    private int startComfort = 5;
    public int interest;
    public int comfort;
    public Image monsterImage;
    public Image kotaroImage;
    public Text winTextBox;

    void Start()
    {
        interest = startInterest;
        comfort = startComfort;
    }

    void Update()
    {
        if (interest >= goalInterest)
        {
            Debug.Log("You win!");
            winTextBox.text = "Okay, I will go to the dance with you.";
            //turn monster sprite into kotaro sprite
            //date message
            //game won
        }
    
        if (comfort <= 0)
        {
            //game over
        }
                      
    }

    public void ChangeInterest(int changeInterest)
    {
        interest += changeInterest;
        Debug.Log("Boss Interest is " + interest.ToString());
    }

    public void ChangeComfort(int changeComfort)
    {
        comfort += changeComfort;
        Debug.Log("Boss Comfort is " + comfort.ToString());
    }

}