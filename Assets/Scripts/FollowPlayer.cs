using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Has to be public 
    public GameObject player;
    private Vector3 offset = new Vector3(0, 23, -12);


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
