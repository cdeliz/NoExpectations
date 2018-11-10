using UnityEngine;
using System.Collections;
using System;

public class MouseMenuFunction : MonoBehaviour
{
    string boxDescription = "";
    GameObject clickObject = null;
    Vector2 boxLocation = new Vector2(0, 0);
    Vector2 mousePos = new Vector2(0, 0);
    Vector2 mouseLocOffset = new Vector2(16, 16);

    void Update()
    {
        ShootRay();
        MouseHover(clickObject);
        if (Input.GetButtonDown("Fire1"))
        {
            MouseClick(clickObject);
        }
    }

    private void ShootRay()
    {
        mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, transform.TransformDirection(Vector3.forward), Color.yellow);
        if (Physics.Raycast(ray.origin, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)) //ray.origin //transform.position
        {
            clickObject = hit.collider.gameObject;
            Debug.Log("Did Hit");
        }
        else
        {
            clickObject = null;
            Debug.Log("Did not Hit");
        }
    }

    private void MouseHover(GameObject hoverObj)
    {
        if (hoverObj != null)
        {
            if (hoverObj.layer == 9)
            {
                boxLocation = new Vector2(mousePos.x, Screen.height - mousePos.y) + mouseLocOffset;
                boxDescription = hoverObj.name;
            }
        }
        else
        {
            boxDescription = "";
        }
    }

    private void MouseClick(GameObject clickObj)
    {
        //activate gameobject OnClick behavior
        //clickObj.OnClick();
        //Debug.Log("FUG");
        //throw new NotImplementedException();
    }

    private void OnGUI()
    {
        if (boxDescription != "" && boxDescription != null)
        {
            GUI.Box(new Rect(boxLocation.x, boxLocation.y, 80, 20), boxDescription);
        }
    }
}