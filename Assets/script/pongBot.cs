using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pongBot : MonoBehaviour
{
    public float ySpeed = 3f;
    private float yPosition = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //see what scene your'e in and then uses the right code for that scene
        //the bot paddle moves up and down and he changes up and down if you hits a specific height
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "pongTwoPlayers")
        {
            if (yPosition >= 3f)
            {
                ySpeed = ySpeed * -1f;
            }
            else if (yPosition <= -3f)
            {
                ySpeed = ySpeed * -1f;
            }
        }
        else if (sceneName == "pongCustom")
        {
            if (yPosition >= 2.3f)
            {
                ySpeed = ySpeed * -1f;
            }
            else if (yPosition <= -2.3f)
            {
                ySpeed = ySpeed * -1f;
            }
        }
    }
}