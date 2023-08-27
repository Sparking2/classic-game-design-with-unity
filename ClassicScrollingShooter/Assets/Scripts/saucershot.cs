using System;
using UnityEngine;

public class saucershot : MonoBehaviour
{
    public float shotspeed = -1.0f;
    public AudioClip clip;

    private void Start() { }

    void Update()
    {
        transform.Translate(0, shotspeed * Time.deltaTime, 0);
        GameObject player = GameObject.Find("ScrollingShipTextured");
        if ( player )
        {
            if ( player.transform.position.x - transform.position.x < -3.0f )
                Destroy(gameObject);
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( other.tag == "terrain" )
        {
            AudioSource.PlayClipAtPoint(clip,gameObject.transform.position,1.0f);
            Destroy(gameObject);
        }

        if ( other.tag == "scrollingship" )
        {
            AudioSource.PlayClipAtPoint(clip,gameObject.transform.position,1.0f);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}