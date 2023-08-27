using System;
using UnityEngine;

public class saucer : MonoBehaviour
{
    public AudioClip clip;
    
    public GameObject saucershot;

    public float radius = 0.2f;
    private float centerx;
    private float centery;
    private float saucertime;

    void Start()
    {
        saucertime = 0;
        centerx = transform.position.x;
        centery = transform.position.y;
    }

    void Update()
    {
        saucertime += Time.deltaTime;
        transform.position = new Vector3(
            centerx + radius * Mathf.Sin(saucertime * 4),
            centery + radius * Mathf.Cos(saucertime * 4),
            transform.position.z
        );

        GameObject player = GameObject.Find("ScrollingShipTextured");
        if ( player )
        {
            if ( player.transform.position.x - transform.position.x < 3.0f )
            {
                if ( saucertime > 3.14159f / 2.0f )
                {
                    Instantiate(saucershot,
                        new Vector3(
                            transform.position.x,
                            transform.position.y,
                            0),
                        Quaternion.AngleAxis(90, Vector3.forward));
                    saucertime = 0.0f;
                }
            }
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
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}