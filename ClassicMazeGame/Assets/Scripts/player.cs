using UnityEngine;

public class player : MonoBehaviour
{
    public AudioClip aleft, aright, aup, adown;


    private readonly float factor = 10.0f;

    private void Start()
    {
        InitPosition();
    }

    private void Update()
    {
        if ( Input.GetKey("right") )
            GetComponent<Rigidbody>().AddForce(Vector3.right * factor);

        if ( Input.GetKey("left") )
            GetComponent<Rigidbody>().AddForce(Vector3.left * factor);

        if ( Input.GetKey("down") )
            GetComponent<Rigidbody>().AddForce(Vector3.back * factor);

        if ( Input.GetKey("up") )
            GetComponent<Rigidbody>().AddForce(Vector3.forward * factor);

        if ( Input.GetKeyDown("right") )
            AudioSource.PlayClipAtPoint(aright, transform.position);
        if ( Input.GetKeyDown("left") )
            AudioSource.PlayClipAtPoint(aleft, transform.position);
        if ( Input.GetKeyDown("up") )
            AudioSource.PlayClipAtPoint(aup, transform.position);
        if ( Input.GetKeyDown("down") )
            AudioSource.PlayClipAtPoint(adown, transform.position);

        if ( scoring.initlevel ) InitPosition();

        if ( scoring.lives == 0 )
            Destroy(gameObject);
        if ( scoring.level == 3 )
            Destroy(gameObject);
    }

    private void InitPosition()
    {
        transform.position = new Vector3(0.0f, 0.3f, 0.5f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}