using System;
using UnityEngine;

public class shipshot : MonoBehaviour
{
    public float shotspeed = 1.0f;

    private void Start() { }

    void Update()
    {
        transform.Translate(0, shotspeed * Time.deltaTime, 0);
        GameObject player = GameObject.Find("ScrollingShipTextured");
        if ( player )
        {
            if ( player.transform.position.x - transform.position.x > 3.0f )
                Destroy(gameObject);
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( other.tag == "terrain" )
        {
            Destroy(gameObject);
        }
    }
}