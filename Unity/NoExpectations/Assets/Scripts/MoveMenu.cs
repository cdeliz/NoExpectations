using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveMenu : MonoBehaviour {

    MoveList moveList;
    private int moveCount = 8;
    public Vector2 menuPosition;
    private Vector2 menuOptionSize;
    private bool shouldDrawMenu;

    // Use this for initialization
    void Start () {
        moveList = GetComponent<MoveList>();
        //moveCount = moveList.Length();
        menuPosition = new Vector2(Screen.width/8, 2*(Screen.height/3));
        menuOptionSize = new Vector2(120, 20);
        shouldDrawMenu = true;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }

    void OnGUI()
    {
        if (shouldDrawMenu)
        {
            Vector2 drawPosition = menuPosition;
            int i = 0;
            for (i = 0; i < moveCount; i++)
            {
                GUI.Button(new Rect(drawPosition, menuOptionSize), moveList.move[i].moveName);
                drawPosition.y += menuOptionSize.y;
                //Debug.Log("DrawPosition Y axis is " + drawPosition.y);
            }

            
        }
    }

    void HideMenu()
    {
        shouldDrawMenu = false;
    }

    void ShowMenu()
    {
        shouldDrawMenu = true;
    }
}
