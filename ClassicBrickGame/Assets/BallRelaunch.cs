using System;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                other.transform.position = new Vector3(0, -7, 0);
                BallScript.xspeed = 8.0f;
                BallScript.yspeed = -8.0f;
                BallScript.launchTimer = 1.0f;
        }
}