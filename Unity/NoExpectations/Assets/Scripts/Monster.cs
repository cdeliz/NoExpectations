using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    int comfort;
    int interest;

    bool isInterestZero()
    {
        return (interest == 0);
    }

	// Use this for initialization
	void Start () {
        interest = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(isInterestZero());
	}
}
