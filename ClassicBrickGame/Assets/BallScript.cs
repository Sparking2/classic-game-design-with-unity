using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallScript : MonoBehaviour
{
    public AudioClip BeepSound;

    public static float launchTimer;
    public static float xspeed;
    public static float yspeed;
    public static bool collflag;

    // Start is called before the first frame update
    void Start()
    {
        launchTimer = 2.0f;
        xspeed = 8.0f;
        yspeed = 8.0f;
        collflag = true;
    }

    // Update is called once per frame
    void Update()
    {
        launchTimer -= Time.deltaTime;
        if ( launchTimer <= 0.0f )
        {
            transform.Translate(
                new Vector3(
                    xspeed * Time.deltaTime,
                    yspeed * Time.deltaTime,
                    0
                ));
            launchTimer = 0.0f;
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}