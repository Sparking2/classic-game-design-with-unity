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
    }

    private void OnTriggerEnter2D( Collider2D other )
    {
        Debug.Log("hmmmm");
        if ( other.tag == "shot" )
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}