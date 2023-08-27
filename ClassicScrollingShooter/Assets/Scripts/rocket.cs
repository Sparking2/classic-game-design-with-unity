using System;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public AudioClip clip;
    public float rocketSpeed;
    private float flighttime = 0.0f;

    void Start() { }

    private void Update()
    {
        GameObject player = GameObject.Find("ScrollingShipTextured");
        if ( player )
        {
            if ( player.transform.position.x - transform.position.x < 0.5f )
            {
                transform.Translate(0, rocketSpeed * Time.deltaTime, 0);
                flighttime += Time.deltaTime;
            }
        }

        if ( flighttime > 5.0f )
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( other.tag == "scrollingship" )
        {
            AudioSource.PlayClipAtPoint(clip,gameObject.transform.position,1.0f);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if ( other.tag == "shipshot" )
        {
            AudioSource.PlayClipAtPoint(clip,gameObject.transform.position,1.0f);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if ( flighttime > 1.0f )
        {
            if ( other.tag == "terrain" )
            {
                AudioSource.PlayClipAtPoint(clip,gameObject.transform.position,1.0f);
                Destroy(gameObject);
            }
        }
    }
}