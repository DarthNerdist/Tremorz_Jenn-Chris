using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTime;

    public Canvas gameOver;
    public Canvas pauseMenu;

    void Start()
    {
        gameOver = gameOver.GetComponent<Canvas>();
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        gameOver.enabled = false;
        pauseMenu.enabled = false;
    }

    void Update()
    {

    }
}