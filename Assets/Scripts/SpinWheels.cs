using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheels : MonoBehaviour
{
    private float wheelSpeed = 3f;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        if(forwardInput>0)    

        transform.Rotate(Vector3.right * wheelSpeed );
        if (forwardInput < 0)
            transform.Rotate(Vector3.right * -wheelSpeed);
    }
}
