using System;
using UnityEngine;

public class WallScript : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                BallScript.xspeed = -BallScript.xspeed;
                BallScript.collflag = true;
        }
}