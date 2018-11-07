using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMapToPlayer : MonoBehaviour
{

    public Camera gameCamera;
    Vector3 camOffset;

    // Use this for initialization
    void Start()
    {
        camOffset = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gameCamera.transform.position = transform.position + camOffset;
        gameCamera.transform.rotation = transform.rotation;
    }
}
