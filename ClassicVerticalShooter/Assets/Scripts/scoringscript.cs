using System;
using UnityEngine;

public class scoringscript : MonoBehaviour
{
    public static int score;
    public static int lives;

    void InitializeGame()
    {
        score = 0;
        lives = 3;
    }

    private void Start()
    {
        InitializeGame();
    }

    private void OnGUI()
    {
        if ( GameStateScript.state == GameStateScript.PressStart )
        {
            if ( GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 50), "Click Me to Start") )
            {
                GameStateScript.state = GameStateScript.StartPlaying;
            }
        }

        if ( GameStateScript.state == GameStateScript.GameOver )
        {
            if ( GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 50, 400, 50),
                    "Game Over, Try again") )
            {
                InitializeGame();
                GameStateScript.state = GameStateScript.PressStart;
            }
        }

        GUI.Box(new Rect(10, 10, 200, 30), "Score: " + score);
        GUI.Box(new Rect(Screen.width - 200, 10, 200, 30), "Lives: " + lives);

        GUI.Box(new Rect(Screen.width / 2 - 30, 10, 90, 30), "State: " + GameStateScript.state);
    }
}