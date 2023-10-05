using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float Speed = 3f;
    public string LeftOrRight;


    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(down))
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
    }

    void Update()
    {
        //Change within Unity if it's left or the right paddle
        if (LeftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (LeftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }

    }
}
