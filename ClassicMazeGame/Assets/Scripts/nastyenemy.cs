using UnityEngine;

public class nastyenemy : MonoBehaviour
{
    public float factor = 5.0f;
    private Vector3 initPosition;
    public AudioClip enemysound;

    private void Start()
    {
        initPosition = transform.position;
    }

    void RestorePosition()
    {
        transform.position = initPosition;
    }

    private void Update()
    {
        Vector3 dir = new Vector3(0, 0, 0);
        GameObject player = GameObject.Find("player");
        if ( player )
        {
            dir = player.transform.position - transform.position;
            GetComponent<Rigidbody>()
                .AddForce(dir * factor * ( 0.6f + 0.2f * scoring.level ));
        }
    }

    private void OnCollisionEnter( Collision collision )
    {
        if ( collision.gameObject.name == "player" )
        {
            AudioSource.PlayClipAtPoint(enemysound, transform.position, 1.0f);
            collision.gameObject.transform.position =
                new Vector3(0, 0.5f, 0.81f);
            RestorePosition();
            scoring.lives--;
        }
    }
}