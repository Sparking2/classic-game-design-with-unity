using UnityEngine;

public class scrollingship : MonoBehaviour
{
    public GameObject shotPrefab;
    public AudioClip clip;

    void Start() { }

    void Update()
    {
        if ( transform.position.y < 5.0f )
        {
            transform.Translate(-0.3f * Time.deltaTime, 0, 0);
        }
        
        if ( Input.GetKey("w") )
        {
            transform.Translate(0, 0.8f * Time.deltaTime, 0);
        }

        if ( Input.GetKey("s") )
        {
            transform.Translate(0, -0.8f * Time.deltaTime, 0);
        }

        if ( Input.GetKeyDown("space") )
        {
            Instantiate(shotPrefab, new Vector3(transform.position.x, transform.position.y, 0.0f),
                Quaternion.AngleAxis(90, Vector3.forward));
            gameObject.GetComponent<AudioSource>().Play();
            }
    }

    private void OnTriggerEnter( Collider other )
    {
        if ( other.tag == "terrain" )
        {
            AudioSource.PlayClipAtPoint(clip,gameObject.transform.position,1.0f);
            Destroy(gameObject);
        }
    }

}