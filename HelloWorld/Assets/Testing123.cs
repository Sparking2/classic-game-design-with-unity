using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing123 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Testing out C# in Unity
    private void OnGUI()
    {
        int result = 2 + 2;
        GUI.Box(new Rect(10,10,240,40), $"Result is {result}");
    }
}
