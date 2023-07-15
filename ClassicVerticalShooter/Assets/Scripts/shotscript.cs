using UnityEngine;

public class shotscript : MonoBehaviour
{
    public float shotSpeed;
    void Start() { }

    void Update()
    {
        transform.Translate(0, shotSpeed * Time.deltaTime, 0);

        if ( transform.position.y > 6.0f ) Destroy(gameObject);
    }
}