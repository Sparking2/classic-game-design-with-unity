using UnityEngine;

public class dot : MonoBehaviour
{
        private void OnTriggerEnter( Collider other )
        {
                if ( other.name == "player" )
                {
                        Destroy(gameObject);
                }
        }
}