using UnityEngine;

public class scoring : MonoBehaviour
{
    public static int score;
    public static int lives;
    public static int dots;
    public static int totaldots;
    public static int level;
    public static bool initlevel;

    private void Start()
    {
        score = 0;
        lives = 3;
        totaldots = 3;
        dots = totaldots;
        level = 1;
        initlevel = false;
    }

    private void Update()
    {
        if ( dots == 0 )
        {
            initlevel = true;
            level++;
        }

        if ( dots == totaldots ) initlevel = false;
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(60, 30, 90, 30), "Score:  " + score);
        GUI.Box(new Rect(Screen.width - 130, 30, 90, 30), "Lives: " + lives);
        GUI.Box(new Rect(Screen.width / 2 - 100, 30, 200, 30), "Dots: " + dots);
        GUI.Box(new Rect(60, Screen.height - 50, 90, 30), "Level: " + level);

        GameObject player = GameObject.Find("player");
        if ( !player )
        {
            GUI.Button(
                new Rect(
                    Screen.width / 2 - 200,
                    Screen.height / 2 - 50,
                    400,
                    50
                ),
                "Game Over");

            if ( level == 3 )
            {
                GUI.Button(
                    new Rect(Screen.width / 2 - 200, Screen.height / 2 - 50,
                        400, 50), "The End");
            }
        }
    }
}