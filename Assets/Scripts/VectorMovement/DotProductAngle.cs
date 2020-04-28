using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductAngle : MonoBehaviour
{
    public Transform Fuel;
    public float speed;
    private Vector3 pos;
    private Vector3 normal;
    private float stoppingDistance = 10f;
    void Start()
    {
        pos = (Fuel.position - this.transform.position);
        // normal.x = pos.x / Mathf.Sqrt((pos.x * pos.x) + (pos.y * pos.y));
        // normal.y = pos.y / Mathf.Sqrt((pos.x * pos.x) + (pos.y * pos.y));
        float dotProduct = pos.x * (transform.position - Vector3.up).x + pos.y * (transform.position - Vector3.up).y;
        float mag = Vector3.Distance(transform.position, Vector3.up) * Vector3.Distance(transform.position, Fuel.position);
        float ang = Mathf.Acos(dotProduct / mag);
        Debug.Log(ang * 180 / Mathf.PI);
    }

}
