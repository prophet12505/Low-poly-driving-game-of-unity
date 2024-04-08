using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed=180f;
    public int coinScore = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
    }

    // check if triggered by player
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            other.GetComponent<PlayerController>().AddScore(coinScore); 
            Destroy(gameObject);

        }
            
    }
}
