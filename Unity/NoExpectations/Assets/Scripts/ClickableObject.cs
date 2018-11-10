using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour {

    public virtual void OnClick()
    {
        Debug.Log("called OnClick");
    }

    public virtual void OnHover()
    {
        Debug.Log("called OnHover");
    }

}
