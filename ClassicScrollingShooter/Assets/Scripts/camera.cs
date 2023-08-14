using System;
using UnityEngine;

public class camera : MonoBehaviour
{
    private void Start() { }

    private void Update()
    {
        GameObject player = GameObject.Find("ScrollingShipTextured");

        float xpos = player.transform.position.x;
        float ypos = player.transform.position.y;

        float new_ypos = transform.position.y;
        if ( new_ypos < ypos - 0.5f ) new_ypos = ypos - 0.5f;
        if ( new_ypos > ypos + 0.5f ) new_ypos = ypos + 0.5f;

        transform.position = new Vector3(
            xpos - 0.7f,
            new_ypos,
            transform.position.z
        );
    }
}