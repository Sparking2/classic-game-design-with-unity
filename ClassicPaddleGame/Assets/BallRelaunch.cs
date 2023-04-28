using System;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                other.transform.position = new Vector3(0, 0, 0);
        }
}