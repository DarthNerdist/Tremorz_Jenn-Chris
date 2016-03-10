using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTime = 5.00f;
    public Text clockText;

    public Canvas gameOver;
    public Canvas pauseMenu;

    void Start()
    {
        clockText = clockText.GetComponent<Text>();

        gameOver = gameOver.GetComponent<Canvas>();
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        gameOver.enabled = false;
        pauseMenu.enabled = false;


    }

    void Update()
    {
        gameTime -= Time.deltaTime;
        clockText.text = gameTime.ToString( "f2" );
        print( gameTime );
    }

    public void GameOver()
    {
        if( gameTime == 0 )
            gameOver.enabled = true;
    }
}