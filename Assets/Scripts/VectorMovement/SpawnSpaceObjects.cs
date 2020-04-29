using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnSpaceObjects : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            obj.transform.position = Random.insideUnitSphere * 1000;
        }
    }
}
