using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject cubePrefab;
        public static float delayTime;
        public static float repeatRate;
        public static bool cubeExist = false;

        //variables for other scripts
        public static float cubeSpeed;// = 4.0f;
        public static float bound;

        //string variables to setup gui
        private string stringDelayTimeText = "Delay Time";
        private string stringCubeSpeedText = "Cube Speed";
        private string stringBoundText = "Bound";
        public string stringDelayTime;
        public string stringCubeSpeed;
        public string stringBound;

        void OnGUI()
        {
            // Make a text field that modifies Cube characteristics
            GUI.TextField(new Rect(10, 10, 200, 20), stringDelayTimeText, 10);
            GUI.TextField(new Rect(10, 30, 200, 20), stringCubeSpeedText, 10);
            GUI.TextField(new Rect(10, 50, 200, 20), stringBoundText, 10);
            stringDelayTime = GUI.TextField(new Rect(250, 10, 50, 20), stringDelayTime, 25);
            delayTime = float.Parse(stringDelayTime);
            stringCubeSpeed = GUI.TextField(new Rect(250, 30, 50, 20), stringCubeSpeed, 25);
            cubeSpeed = float.Parse(stringCubeSpeed);
            stringBound = GUI.TextField(new Rect(250, 50, 50, 20), stringBound, 25);
            bound = float.Parse(stringBound);
        }

        void Update()
        {
            //Create new Cube after delayTime seconds and if other one not exist
            if (Time.time > repeatRate)
            {
                if (!cubeExist)//if you don't want to check if the cube exists just delete this if branching
                {
                    Instantiate(cubePrefab, new Vector3(0, 0, 0), cubePrefab.transform.rotation);
                    cubeExist = true;
                }
            }
        }
    }
}