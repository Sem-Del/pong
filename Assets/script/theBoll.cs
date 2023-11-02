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
        //set ball loction to the middle
        //update the score
        //let the ball go to the side of the person that made the point.
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
        //see what scene your'e in and then uses the right code for that scene
        //if left or right score is topscore then stop the ball and say the winner
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "pongTwoPlayers")
        {
            if (leftScore >= topScore)
            {
                scoreboard.text = "left won";
                xSpeed = 0;
                ySpeed = 0;
                xBallLocation = 0;
                yBallLocation = 0;
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
        else if (sceneName == "pongCustom")
        {
            if (leftScore >= topScore)
            {
                scoreboard.text = "left won";
                xSpeed = 0;
                ySpeed = 0;
                xBallLocation = 0;
                yBallLocation = 0;

            }
            else if (rightScore >= topScore)
            {
                scoreboard.text = "Bot won!";
                xSpeed = 0;
                ySpeed = 0;
                xBallLocation = 0f;
                yBallLocation = 0f;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if you hit a specific wall or player then the direction changes to the otherside and if it is a player it goes also a little faster
        //if it hits the left or right wall then the other player get a point and the ball resets.
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