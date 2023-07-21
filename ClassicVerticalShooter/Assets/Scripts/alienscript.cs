using System;
using UnityEngine;

public class alienscript : MonoBehaviour
{
    public GameObject ashot;
    public int chance = 900;


    private void Update()
    {
        if ( Mathf.FloorToInt(UnityEngine.Random.value * 10000.0f) % chance == 0 )
        {
            Instantiate(ashot, new Vector3(transform.position.x, transform.position.y, 0.5f), Quaternion.identity);
        }

        if ( GameStateScript.state == GameStateScript.PressStart )
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D( Collider2D other )
    {
        if ( other.tag == "shot" )
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            scoringscript.score += 10;
        }
    }
}