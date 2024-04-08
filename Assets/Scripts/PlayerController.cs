using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //crrl + l format document 
    private readonly float moveSpeed = 15.0f;
    private readonly float turnSpeed = 90.0f;
    // Start is called before the first frame update
    //this is the player input
    private float forwardInput;
    private float horizontalInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;


    //scoreboard
    public static int score;
    public TextMeshProUGUI scoreText;
    


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput, 0f, forwardInput);

        transform.Translate(moveSpeed * Vector3.forward * forwardInput * Time.deltaTime);
        //slide player from side to side, alternative way
        //transform.Translate(turnSpeed * Vector3.right * horizontalInput * Time.deltaTime);
        //turn player 
        //todo: invert the controll while backing up
        
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        //check if player fell off road
        if (transform.position.y < -5)
        {
            GameOver();
        }
        // toggle one camera on and the other off
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = ! mainCamera.enabled;
            hoodCamera.enabled = ! hoodCamera.enabled;
        }
    }
    //GameOver is called when game is over
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        throw new NotImplementedException();
    }

    public void AddScore(int amount)//
    {
        score += amount;
        scoreText.text = "Score: " + score.ToString();

    }
}
