using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveList : MonoBehaviour {

    public Move[] move;
    private int moveCount; //someday this can be set on creation

    // Use this for initialization
    void Start () {
        moveCount = 8; //magic numbuh bitches!!!
        move = new Move[moveCount];
        //remove later
        debugInitializeMenu();
	}

    void debugInitializeMenu()
    {
        int i;
        for (i = 0; i < moveCount; i++)
        {
            move[i] = new Move();
            move[i].moveName = "Move " + i.ToString();
            move[i].moveDescription = "Move " + i.ToString() + " Description";
            Debug.Log("initialized move table: entry " + i.ToString() + " created");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int Length()
    {
        return move.Length;
    }
    
}
