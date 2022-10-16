using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject cubePrefab;
        public static float delayTime = 2.0f;
        public static bool cubeExist = false;

        //variables for other scripts
        public static float cubeSpeed = 4.0f;
        public static float bound = 5.0f;

        void Update()
        {
            //Create new shelter if other one not exist
            if (Time.time > delayTime && !cubeExist)
            {
                Instantiate(cubePrefab, new Vector3(0, 0, 0), cubePrefab.transform.rotation);
                cubeExist = true;
            }
        }
    }
}