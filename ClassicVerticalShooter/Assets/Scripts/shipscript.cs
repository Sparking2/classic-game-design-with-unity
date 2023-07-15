using UnityEngine;

public class shipscript : MonoBehaviour
{
    public float shipSpeed;
    public float screenBoundary;
    public GameObject shot;

    void Start()
    {
        transform.position = new Vector3(0, -2, 0);
    }

    void Update()
    {
        if ( Input.GetKey("right") )
        {
            transform.Translate(shipSpeed * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("left") )
        {
            transform.Translate(-shipSpeed * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKeyDown("space") )
        {
            Instantiate(shot, new Vector3(transform.position.x, transform.position.y, 0.5f), Quaternion.identity);
        }

        if ( transform.position.x < -screenBoundary )
        {
            transform.position = new Vector3(-screenBoundary, transform.position.y, transform.position.z);
        }

        if ( transform.position.x > screenBoundary )
        {
            transform.position = new Vector3(screenBoundary, transform.position.y, transform.position.z);
        }
    }
}