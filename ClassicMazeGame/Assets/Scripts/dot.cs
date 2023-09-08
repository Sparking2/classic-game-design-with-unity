using UnityEngine;

public class dot : MonoBehaviour
{
    public AudioClip dotsound;

    private void OnTriggerEnter( Collider other )
    {
        if ( other.name == "player" )
        {
            AudioSource.PlayClipAtPoint(dotsound, transform.position, 1.0f);
            Destroy(gameObject);
        }
    }
}