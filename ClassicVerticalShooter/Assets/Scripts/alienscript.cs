using System;
using UnityEngine;

public class alienscript : MonoBehaviour
{
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