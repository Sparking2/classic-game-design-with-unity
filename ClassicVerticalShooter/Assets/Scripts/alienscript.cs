using System;
using UnityEngine;

public class alienscript : MonoBehaviour
{
    public GameObject ashot;
    public int chance = 900;
    public int state;
    public float timer;

    private void Start() { }

    private void Update()
    {
        if ( GameStateScript.state == GameStateScript.GamePlay )
        {
            if ( Mathf.FloorToInt(UnityEngine.Random.value * 10000.0f) % chance == 0 )
            {
                Instantiate(ashot, new Vector3(transform.position.x, transform.position.y, 0.5f), Quaternion.identity);
            }

            if ( state == 1 )
            {
                transform.Rotate(0, 0, Time.deltaTime * 400.0f);
                transform.Translate(0.3f * Time.deltaTime, 3.0f * Time.deltaTime, 0, Space.World);
                transform.localScale = transform.localScale * 0.99f;
                timer -= 0.1f;
                if ( timer < 0.0f )
                {
                    Destroy(gameObject);
                }
            }

            if ( GameStateScript.state == GameStateScript.PressStart )
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D( Collider2D other )
    {
        if ( other.tag == "shot" )
        {
            scoringscript.score += 10;
            gameObject.GetComponent<AudioSource>().Play();
            state = 1;
            timer = 5.0f;
            Destroy(other.gameObject);
        }
    }
}