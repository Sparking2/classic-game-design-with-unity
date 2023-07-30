using UnityEngine;

public class scrollingship : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        transform.Translate(-0.3f * Time.deltaTime, 0, 0);
        if ( Input.GetKey("w") )
        {
            transform.Translate(0, 0.8f * Time.deltaTime, 0);
        }

        if ( Input.GetKey("s") )
        {
            transform.Translate(0, -0.8f * Time.deltaTime, 0);
        }
    }
}