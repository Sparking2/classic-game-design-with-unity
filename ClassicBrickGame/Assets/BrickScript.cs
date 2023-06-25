using UnityEngine;

public class BrickScript : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                if ( BallScript.collflag == true )
                {
                        BallScript.yspeed = -BallScript.yspeed;
                        BallScript.collflag = false;
                        Destroy(gameObject);
                }
        }
}