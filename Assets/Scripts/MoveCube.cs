using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MoveCube : MonoBehaviour
    {
        // Update is called once per frame
        //get cubeSpeed from SpawnManager
        void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * SpawnManager.cubeSpeed);
        }
    }
}
