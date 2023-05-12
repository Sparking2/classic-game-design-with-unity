using UnityEngine;

public class WallTopScript : MonoBehaviour
{
    private void OnTriggerEnter( Collider other )
    {
        BallScript.yspeed = -BallScript.yspeed;
        BallScript.collflag = true;
    }
}