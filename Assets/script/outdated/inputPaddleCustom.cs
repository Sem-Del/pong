using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddleCustom : MonoBehaviour
{
    public float Speed = 3f;
    public string RightOrLeft;

    //see what the up and down key
    //check if you are not higher then a specific height and if you are heigher then dont go further ortherwise you can go up or down
    void setKeyAndMovement(KeyCode up, KeyCode down)
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
