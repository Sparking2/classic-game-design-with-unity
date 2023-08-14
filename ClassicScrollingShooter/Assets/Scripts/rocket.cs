using System;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public float rocketSpeed;

    void Start() { }

    private void Update()
    {
        GameObject player = GameObject.Find("ScrollingShipTextured");
        if ( player )
        {
            if ( player.transform.position.x - transform.position.x < 0.5f )
            {
                transform.Translate(0, rocketSpeed * Time.deltaTime, 0);
            }
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( other.tag == "scrollingship" )
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}