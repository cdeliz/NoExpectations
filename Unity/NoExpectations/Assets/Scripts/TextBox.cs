using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBox : ClickableObject {

    string[] textArray;
    int textBoxHeight = Screen.height / 4;
    int currentTextField;

	// Use this for initialization
	void Start () {
        textArray = new string[2];
        textArray[0] = "Example Text";  //Add function replace?
        textArray[1] = "Continued Text";
        currentTextField = 0;
	}

    public override void OnClick()
    {
        if(currentTextField < textArray.Length)
        currentTextField++;
        //else close text box
    }

    public override void OnHover()
    {
        base.OnHover();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, Screen.height-textBoxHeight, Screen.width, textBoxHeight), "textArray[currentTextField]");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
