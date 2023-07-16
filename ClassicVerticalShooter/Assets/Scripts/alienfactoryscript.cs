using System;
using UnityEngine;

public class alienfactoryscript : MonoBehaviour
{
    public GameObject alien;

    public void MakeAliens()
    {
        for ( int i = 0; i < 15; i++ )
        {
            for ( int j = 0; j < 6; j++ )
            {
                GameObject al = Instantiate(alien, new Vector3(( i - 7 ) * 0.5f, ( j - 2 ) * 0.8f, 0),
                    Quaternion.identity);
            }
        }
    }

    private void Start()
    {
        MakeAliens();
    }
}