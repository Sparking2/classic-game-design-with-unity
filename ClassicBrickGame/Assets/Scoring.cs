using System;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int score;
    public static int lives;

    void Start()
    {
        score = 0;
        lives = 3;
    }

    void Update() { }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 90, 30),
            "Score: " + score);
        GUI.Box(new Rect(Screen.width - 100, 10, 90, 30), "Lives: " + lives);
    }
}