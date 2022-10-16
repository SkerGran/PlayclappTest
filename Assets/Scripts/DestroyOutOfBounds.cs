using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class DestroyOutOfBounds : MonoBehaviour
    {
        void Update()
        {
            if (transform.position.z > SpawnManager.bound)
            {
                Destroy(gameObject);
                SpawnManager.cubeExist = false;
                SpawnManager.repeatRate = Time.time + SpawnManager.delayTime;
            }
        }
    }
}
