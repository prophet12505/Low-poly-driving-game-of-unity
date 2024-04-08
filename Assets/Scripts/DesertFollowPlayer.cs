using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertFollowPlayer : MonoBehaviour
{
    //Has to be public 
    public GameObject player;
    private Vector3 offset = new Vector3(0.26f, 2.3f, -6.98f);

    public Vector3 PlayerPosition;


    // Update is called once per frame
    void LateUpdate()
    {
        PlayerPosition=transform.position;

        transform.position = player.transform.position + offset;
    }
}
