using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inputPaddle : MonoBehaviour
{
    public float Speed = 3f;
    public string RightOrLeft;

    //see what the up and down key
    //see what scene your'e in and then uses the right code for that scene
    //check if you are not higher then a specific height and if you are heigher then dont go further ortherwise you can go up or down
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "pongTwoPlayers")
        {
            if (Input.GetKey(up) && transform.position.y <= 3.2f)
            {
                transform.Translate(Vector3.up * Speed * Time.deltaTime);
            }
            else if (Input.GetKey(down) && transform.position.y >= -3.2f)
            {
                transform.Translate(Vector3.down * Speed * Time.deltaTime);
            }
        }
        else if (sceneName == "pongCustom")
        {
            if (Input.GetKey(up) && transform.position.y <= 2.49f)
            {
                transform.Translate(Vector3.up * Speed * Time.deltaTime);
            }
            else if (Input.GetKey(down) && transform.position.y >= -2.47f)
            {
                transform.Translate(Vector3.down * Speed * Time.deltaTime);
            }
        }
    }

    void Update()
    {
        //Change within Unity if it's left or the right paddle
        //left or right decides what controles you have to use for the paddle to move
        if (RightOrLeft == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (RightOrLeft == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }

    }
}
