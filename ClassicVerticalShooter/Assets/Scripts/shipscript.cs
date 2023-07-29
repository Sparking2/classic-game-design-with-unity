using System;
using UnityEngine;

public class shipscript : MonoBehaviour
{
    public alienfactoryscript alienfactory;
    public float shipSpeed;
    public float screenBoundary;
    public GameObject shot;

    private float deathTimer;

    void Start()
    {
        transform.position = new Vector3(0, -2, 0);
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if ( GameStateScript.state == GameStateScript.GamePlay )
        {
            ShipControl();
            if ( scoringscript.aliencounter == 0 )
            {
                GameStateScript.state = GameStateScript.StartPlaying;
                scoringscript.level++;
            }
        }

        if ( GameStateScript.state == GameStateScript.StartPlaying )
        {
            alienfactory.MakeAliens();
            GameStateScript.state = GameStateScript.GamePlay;
        }

        if ( GameStateScript.state == GameStateScript.Dying )
        {
            transform.Rotate(0, 0, Time.deltaTime * 400.0f);
            deathTimer -= 0.1f;
            if ( deathTimer < 5.0f )
            {
                GetComponent<Renderer>().enabled = false;
            }

            if ( deathTimer < 0 )
            {
                GameStateScript.state = GameStateScript.GamePlay;
                transform.position = new Vector3(0.0f, transform.position.y, 0.0f);
                transform.rotation = Quaternion.identity;
                GetComponent<Renderer>().enabled = true;

                if ( scoringscript.lives == 0 )
                {
                    GameStateScript.state = GameStateScript.GameOver;
                }
            }
        }
    }

    void ShipControl()
    {
        if ( Input.GetKey("right") )
        {
            transform.Translate(shipSpeed * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("left") )
        {
            transform.Translate(-shipSpeed * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKeyDown("space") )
        {
            Instantiate(shot, new Vector3(transform.position.x, transform.position.y, 0.5f), Quaternion.identity);
            gameObject.GetComponent<AudioSource>().Play();
        }

        if ( transform.position.x < -screenBoundary )
        {
            transform.position = new Vector3(-screenBoundary, transform.position.y, transform.position.z);
        }

        if ( transform.position.x > screenBoundary )
        {
            transform.position = new Vector3(screenBoundary, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D( Collider2D other )
    {
        if ( GameStateScript.state == GameStateScript.GamePlay )
        {
            if ( other.tag == "ashot" )
            {
                scoringscript.lives--;
                deathTimer = 10.0f;
                GameStateScript.state = GameStateScript.Dying;
                Destroy(other.gameObject);
            }
        }
    }
}