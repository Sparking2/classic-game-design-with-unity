using UnityEngine;

public class player : MonoBehaviour
{
    public AudioClip aleft, aright, aup, adown;

    void Start() { }

    private float factor = 10.0f;

    void Update()
    {
        if ( Input.GetKey("right") )
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * factor);
        }

        if ( Input.GetKey("left") )
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * factor);
        }

        if ( Input.GetKey("down") )
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * factor);
        }

        if ( Input.GetKey("up") )
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * factor);
        }

        if ( Input.GetKeyDown("right") )
            AudioSource.PlayClipAtPoint(aright, transform.position);
        if ( Input.GetKeyDown("left") )
            AudioSource.PlayClipAtPoint(aleft, transform.position);
        if ( Input.GetKeyDown("up") )
            AudioSource.PlayClipAtPoint(aup, transform.position);
        if ( Input.GetKeyDown("down") )
            AudioSource.PlayClipAtPoint(adown, transform.position);
    }
}