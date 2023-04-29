using System;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                if ( other.transform.position.x > 0 )
                        Scoring.scorep1++;
                else
                        Scoring.scorep2++;
                
                other.transform.position = new Vector3(0, 0, 0);
        }
}