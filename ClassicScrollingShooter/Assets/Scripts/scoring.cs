using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour
{
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update() { }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 120, 30), "Score: " + score);

        GameObject player = GameObject.Find("ScrollingShipTextured");
        if ( !player )
        {
            GUI.Button(
                new Rect(Screen.width / 2 - 200,
                    Screen.height / 2 - 50,
                    400, 100), "Game Over"
            );
        }

        if ( player )
        {
            if ( player.transform.position.x < -24.0f )
            {
                GUI.Button(
                    new Rect(Screen.width / 2 - 200,
                        Screen.height / 2 - 50,
                        400, 100), "The End"
                );
            }
        }
    }
}