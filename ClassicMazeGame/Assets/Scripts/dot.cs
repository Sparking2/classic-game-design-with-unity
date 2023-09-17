using UnityEngine;

public class dot : MonoBehaviour
{
    public AudioClip dotsound;

    private void Start() { }

    private void Update()
    {
        if ( scoring.initlevel ) Revive();
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( other.name == "player" )
        {
            AudioSource.PlayClipAtPoint(dotsound, transform.position, 1.0f);
            Suspend();
            scoring.dots--;
            scoring.score += 10;
            Destroy(gameObject);
        }
    }

    private void Suspend()
    {
        gameObject.transform.position = new Vector3(
            transform.position.x,
            20.0f,
            transform.position.z);
    }

    private void Revive()
    {
        gameObject.transform.position = new Vector3(
            transform.position.x,
            0.3f,
            transform.position.z
        );
    }
}