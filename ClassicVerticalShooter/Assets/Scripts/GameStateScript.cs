using System;
using UnityEngine;

public class GameStateScript : MonoBehaviour
{
    public static int state;
    public const int PressStart = 1;
    public const int StartPlaying = 2;
    public const int GamePlay = 3;
    public const int Dying = 4;
    public const int GameOver = 5;
    public const int NextLevel = 6;

    private void Start()
    {
        state = PressStart;
    }
}