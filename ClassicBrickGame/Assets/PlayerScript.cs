using System;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if ( Input.GetKey("left") )
        {
            transform.Translate(-20 * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("right") )
        {
            transform.Translate(20 * Time.deltaTime, 0, 0);
        }

        float h;
        h = 30.0f * Time.deltaTime * Input.GetAxis("Mouse X");
        transform.Translate(h, 0, 0);
    }

    private void OnTriggerEnter( Collider other )
    {
        BallScript.yspeed = -BallScript.yspeed;
        if ( other.transform.position.x > gameObject.transform.position.x )
        {
            BallScript.xspeed = Mathf.Abs(BallScript.xspeed);
        }
        else
        {
            BallScript.xspeed = -Math.Abs(BallScript.xspeed);
        }
        BallScript.collflag = true;
    }
}