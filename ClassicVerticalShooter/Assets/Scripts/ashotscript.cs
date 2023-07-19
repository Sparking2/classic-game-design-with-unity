using UnityEngine;

public class ashotscript : MonoBehaviour
{
    public float ashotSpeed;

    void Start() { }

    void Update()
    {
        transform.Translate(0, ashotSpeed * Time.deltaTime, 0);
        if ( transform.position.y < -16 ) Destroy(gameObject);
    }
}