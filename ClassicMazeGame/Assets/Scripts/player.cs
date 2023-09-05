using UnityEngine;

public class player : MonoBehaviour
{
        void Start(){}

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
        }
}