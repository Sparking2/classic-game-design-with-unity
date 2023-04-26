using System;
using System.Collections;
using UnityEngine;

public class BallScript : MonoBehaviour
{
        private void Start()
        {
                Rigidbody rigidb = GetComponent<Rigidbody>();
                if ( rigidb )
                {
                        rigidb.freezeRotation = true;
                }

                StartCoroutine(nameof( WaitForIt ));
        }

        private void Update()
        {
        }

        private IEnumerator WaitForIt()
        {
                Rigidbody rigidb = GetComponent<Rigidbody>();
                yield return new WaitForSeconds(3);
                if ( rigidb )
                {
                        rigidb.AddForce(UnityEngine.Random.Range(6,0),UnityEngine.Random.Range(-4,-3),0);
                }
        }
}