using System;
using UnityEngine;

public class MakeBricksScript : MonoBehaviour
{
    private void Start()
    {
        for ( int y = 0; y < 8; y++ )
        {
            for ( int x = 0; x < 15; x++ )
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x * 2 - 14, y - 1, 0);
                cube.transform.localScale = new Vector3(1.9f, 0.9f, 1);
                
                // cube.AddComponent<BrickScript>();

                Material m_material = cube.GetComponent<Renderer>().material;
                if ( y < 2 )
                    m_material.color = Color.yellow;
                else if ( y < 4 )
                    m_material.color = Color.cyan;
                else if ( y < 6 )
                    m_material.color = Color.blue;
                else if(y < 8)
                    m_material.color = Color.red;

                cube.GetComponent<Collider>().isTrigger = true;
            }
        }
    }
}