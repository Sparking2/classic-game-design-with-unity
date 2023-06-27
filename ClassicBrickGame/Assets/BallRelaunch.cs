using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallRelaunch : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                Scoring.lives--;
                other.transform.position = new Vector3(0, -7, 0);
                BallScript.xspeed = 8.0f;
                BallScript.yspeed = -8.0f;
                BallScript.launchTimer = 1.0f;

                if ( Scoring.lives == 0 )
                {
                        SceneManager.LoadScene("BrickTitleScene");
                }
        }
}