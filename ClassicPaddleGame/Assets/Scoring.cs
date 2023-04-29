using System;
using UnityEngine;

public class Scoring : MonoBehaviour
{
        public static int scorep1;
        public static int scorep2;

        private void Start()
        {
                scorep1 = 0;
                scorep2 = 0;
        }

        private void OnGUI()
        {
                GUI.Box(new Rect(10,10,200,30),"Player 1 Score:" + scorep1);
                GUI.Box(new Rect(Screen.width - 250,10,200,30), "Player 2 Score: " + scorep2);
        }
}