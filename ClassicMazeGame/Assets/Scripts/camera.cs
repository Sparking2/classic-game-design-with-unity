using UnityEngine;

public class camera : MonoBehaviour
{
    private void Update()
    {
        GameObject player = GameObject.Find("player");
        if ( player )
        {
            transform.position = new Vector3(
                player.transform.position.x,
                transform.position.y,
                player.transform.position.z
            );
        }
    }
}