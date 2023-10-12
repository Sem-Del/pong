using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float Speed = 3f;
    public string RightOrLeft;

    void setKeyAndMovement(KeyCode up, KeyCode down)
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

    void Update()
    {
        //Change within Unity if it's left or the right paddle
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
