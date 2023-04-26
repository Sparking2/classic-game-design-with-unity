using System;
using UnityEngine;

public class P1 : MonoBehaviour
{
        private void Update()
        {
                if ( Input.GetKey("w") )
                {
                        transform.Translate(0,20*Time.deltaTime,0);
                }

                if ( Input.GetKey("s") )
                {
                        transform.Translate(0,-20*Time.deltaTime,0);
                }
        }
}