using UnityEngine;

public class P2 : MonoBehaviour
{
        private void Update()
        {
                if ( Input.GetKey("up") )
                {
                        transform.Translate(0,20*Time.deltaTime,0);
                }

                if ( Input.GetKey("down") )
                {
                        transform.Translate(0,-20*Time.deltaTime,0);
                }
        }
}