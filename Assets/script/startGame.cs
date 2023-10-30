using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void startTwoPlayers()
    {
        SceneManager.LoadScene("pongTwoPlayers");
    }
    public void startOnePlayer()
    {
        SceneManager.LoadScene("pongOnePlayer");
    }
}