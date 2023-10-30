using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Threading;

public class theBoll : MonoBehaviour
{
    public float xBallLocation;
    public float yBallLocation = 0f;
    public float xSpeed;
    public float ySpeed;
    public TMP_Text scoreboard;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 10;
    //int milliseconds = 2000;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 3f;
        ySpeed = 3f;
        xBallLocation = 0;
        yBallLocation = Random.Range(-3f,3f);
    }
    private void resetBall(string leftOrRight)
    {
        xBallLocation = 0f;
        yBallLocation = Random.Range(-3f, 3f);
        scoreboard.text = leftScore + " - " + rightScore;
        if (leftOrRight == "left")
        {
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xBallLocation += xSpeed * Time.deltaTime;
        yBallLocation += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xBallLocation, yBallLocation, 0);
        if (leftScore >= topScore)
        {
            scoreboard.text = "left won";
            xSpeed = 0;
            ySpeed = 0;
            xBallLocation = 0;
            yBallLocation = 0;
            //back to menu with a delay (does not work)
            //Thread.Sleep(milliseconds);
            //SceneManager.LoadScene("startMenu");

            //back to menu with a delay (does not work)
            ////yield return WaitForSeconds(2f);
            //SceneManager.LoadScene("startMenu");

        }
        else if (rightScore >= topScore)
        {
            scoreboard.text = "Right won!";
            xSpeed = 0;
            ySpeed = 0;
            xBallLocation = 0f;
            yBallLocation = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wallUp"))
        {
            ySpeed *= -1f;
        }
        else if (collision.gameObject.CompareTag("wallDown"))
        {
            ySpeed *= -1f;
        }
        else if (collision.gameObject.CompareTag("wallLeft"))
        {
            rightScore++;
            resetBall("left");
        }
        else if (collision.gameObject.CompareTag("wallRight"))
        {
            leftScore++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("player"))
        {
            xSpeed *= -1.1f;
        }
    }
}
