using UnityEngine;

public class starfield_scroller : MonoBehaviour
{
    public float scrollspeed;

    void Start() { }

    void Update()
    {
        transform.Translate(0, scrollspeed * Time.deltaTime, 0);
        if ( transform.position.y < -10.0f )
        {
            transform.Translate(0, 20.48f, 0);
        }
    }
}