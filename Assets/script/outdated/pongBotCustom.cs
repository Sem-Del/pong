using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBotCustom : MonoBehaviour
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
        //the bot paddle moves up and down and he changes up and down if you hits a specific height
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
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