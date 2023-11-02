using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    //If button start Two player pong is pressed load scene pongTwoPlayers
    public void startTwoPlayers()
    {
        SceneManager.LoadScene("pongTwoPlayers");
    }
    //If button start One player pong is pressed load scene pongOnePlayer
    public void startOnePlayer()
    {
        SceneManager.LoadScene("pongOnePlayer");
    }
    //If button start Custom pong is pressed load scene pongCustom
    public void startCustomPong()
    {
        SceneManager.LoadScene("pongCustom");
    }
}