using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxHandler : MonoBehaviour {

    Text TargetTextBox;

    private void Start()
    {
        TargetTextBox = GetComponentInChildren(typeof(Text)) as Text;
        if(TargetTextBox == null)
        {
            Debug.LogError("Error: There is a Text Box Handler assigned, but there is no Text Box assigned to that GameObject");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
