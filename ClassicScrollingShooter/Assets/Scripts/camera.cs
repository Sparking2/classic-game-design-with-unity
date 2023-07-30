using System;
using UnityEngine;

public class camera : MonoBehaviour
{
    private void Start() { }

    private void Update()
    {
        GameObject player = GameObject.Find("ScrollingShipTextured");
        transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y,
            transform.position.z
        );
    }
}