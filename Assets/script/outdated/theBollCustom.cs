using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Threading;

public class theBollCustom : MonoBehaviour
{
    public float xBallLocation;
    public float yBallLocation = 0f;
    public float xSpeed;
    public float ySpeed;
    public TMP_Text scoreboard;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 100;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 7f;
        ySpeed = 7f;
        xBallLocation = 0;
        yBallLocation = Random.Range(-3f, 3f);
    }
    //set ball loction to the middle
    //update the score
    //let the ball go to the side of the person that made the point.
    private void resetBall(string leftOrRight)
    {
        xBallLocation = 0f;
        yBallLocation = Random.Range(-5f, 5f);
        scoreboard.text = leftScore + " - " + rightScore;
        if (leftOrRight == "left")
        {
            xSpeed = 7f;
            ySpeed = 7f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = -7f;
            ySpeed = 7f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xBallLocation += xSpeed * Time.deltaTime;
        yBallLocation += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xBallLocation, yBallLocation, 0);
        //if left or right score is topscore then stop the ball and say the winner
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
    //if you hit a specif wall or player then the direction changes to the otherside and goes a little faster
    //if it hits the left or right wall then the other player get a point and the ball resets
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
