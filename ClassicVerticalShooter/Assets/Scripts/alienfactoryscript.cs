using System;
using UnityEngine;

public class alienfactoryscript : MonoBehaviour
{
    public GameObject alien;

    public void MakeAliens()
    {
        scoringscript.aliencounter = 0;
        
        for ( int i = 0; i < 15; i++ )
        {
            for ( int j = 0; j < 6; j++ )
            {
                scoringscript.aliencounter++;
                GameObject al = Instantiate(alien, new Vector3(( i - 7 ) * 0.5f, ( j - 2 ) * 0.8f, 0),
                    Quaternion.identity);
                al.GetComponent<alienscript>().state = 0;
            }
        }
    }

    private void Start() { }
}