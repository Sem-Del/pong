using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBoll : MonoBehaviour
{
    public float xBallLocation = Random.value;
    public float yBallLocation = 0f;
    public float xSpeed;
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 2f;
        ySpeed = 2f;
        xBallLocation = 0;
        yBallLocation = 0;

    }

    // Update is called once per frame
    void Update()
    {
        xBallLocation += xSpeed * Time.deltaTime;
        yBallLocation += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xBallLocation, yBallLocation, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wallLeft"))
        {
            xSpeed *= -1f;
        }
        else if (collision.gameObject.CompareTag("wallRight"))
        {
            xSpeed *= -1f;
        }
        else if (collision.gameObject.CompareTag("wallUp"))
        {
            ySpeed *= -1f;
        }
        else if (collision.gameObject.CompareTag("wallDown"))
        {
            ySpeed *= -1f;
        }
    }
}